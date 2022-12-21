using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Elliptic_Curves
{
    public partial class Form1 : Form
    {
        int[] d;
        int a;
        int b;
        int mod;
        bool zero;
        Dictionary<char, (int, int)> alpha;

        public Form1()
        {
            InitializeComponent();

            d = new int[2];
            zero = false;
            alpha = new Dictionary<char, (int, int)> 
            {
                { 'a', (12,29)},
                { 'b', (15,20)},
                { 'c', (23,4)},
                { 'd', (1,28)},
                { 'e', (7,5)},
                { 'f', (27,22)},
                { 'g', (27,19)},
                { 'h', (7,36)},
                { 'i', (1,13)},
                { 'j', (23,37)},
                { 'k', (15,21)},
                { 'l', (12,12)},
                { '.', (0,0)}
            };

        }

        // Поиск целых точек из уравнения y^2=x^3+ax+b (mod p)
        private List<(int, int)> CurveOrder()
        {
            List<(int, int)> points = new List<(int, int)>();

            for (int i = 0; i < mod; i++)
            {
                double y = Math.Sqrt((i * i * i + a * i + b) % mod);
                string[] array = y.ToString().Split(',');

                if (array.Length == 1)
                {
                    points.Add((i, (int)y));

                    if (y != 0)
                    {
                        int y3 = mod - (int)y;
                        points.Add((i, y3));
                    }
                }
            }

            return points;
        }

        // Вычисление x^(-1) (mod p)
        private int Gcd(int a, int m)
        {
            int modul = (int)BigInteger.ModPow(a, m - 2, m);
            modul = modul < 0 ? m - Math.Abs(modul) : modul;

            return modul;
        }

        // Приведение отрицательного числа к положительному
        private int Mod(int a, int m)
        {
            return m - Math.Abs(a);
        }

        // Вычисление координат x3, y3
        private (int, int) CoordsCalc((int, int) p, (int, int) p1, int lamda)
        {
            lamda = lamda < 0 ? Mod(lamda, mod) : lamda;

            int x3 = (lamda * lamda - p.Item1 - p1.Item1) % mod;
            x3 = x3 < 0 ? Mod(x3, mod) : x3;

            int y3 = (lamda * (p.Item1 - x3) - p.Item2) % mod;
            y3 = y3 < 0 ? Mod(y3, mod) : y3;

            return (x3, y3);
        }

        // Сложение точек (поиск точек на кривой)
        private (int, int) PointCalc((int, int) p, (int, int) p1, bool mode)
        {
            if (p.Item1 == 0 && p.Item2 == 0 && mode)
                return p1;

            if (p == p1)
            {
                int lamda = (3 * p.Item1 * p.Item1 + a) * Gcd(2 * p.Item2, mod) % mod;
                p1 = CoordsCalc(p, p1, lamda);
            }
            else
            {
                zero = (p1.Item1 - p.Item1 == 0) ? true : false;
                if (!zero)
                {
                    int lamda = (p1.Item2 - p.Item2) * Gcd(p1.Item1 - p.Item1, mod) % mod;
                    p1 = CoordsCalc(p, p1, lamda);
                }
                else
                {
                    if (mode) p1 = (0, 0);
                }
            }

            return p1;
        }

        // Сложение каждой точки из спсика самой с собой
        private List<(int, int)> SumPoints(List<(int, int)> points)
        {
            List<(int, int)> sPoints = new List<(int, int)>();

            for (int j = 0; j < points.Count(); j++)
            {
                (int, int) p = points[j];
                (int, int) p1 = points[j];

                for (int i = 0; i < mod - 2; i++)
                {
                    p1 = PointCalc(p, p1, false);

                    if (!sPoints.Contains(p1))
                        sPoints.Add(p1);
                }
            }

            return sPoints;
        }

        // Умножение точки на число
        private (int, int) SumPoints((int, int) point, int count, bool mode)
        {
            (int, int) p1 = point;

            for (int i = 0; i < count - 1; i++)
            {
                if (mode == false)
                    p1 = PointCalc(point, p1, false);
                else
                {                   
                    p1 = PointCalc(point, p1, true);
                }    
            }

            return p1;
        }

        // Определение порядка каждой из точек кривой
        private Dictionary<int, List<(int, int)>> Order(List<(int, int)> sPoints)
        {
            Dictionary<int, List<(int, int)>> curveInfo = new Dictionary<int, List<(int, int)>>();
            int count;

            for (int j = 0; j < sPoints.Count(); j++)
            {
                (int, int) p = sPoints[j];
                (int, int) p1 = sPoints[j];

                count = 2;
                zero = false;

                for (int i = 0; i < (mod - 2) && !zero; i++)
                {
                    p1 = PointCalc(p, p1, false);                  

                    if (zero && curveInfo.ContainsKey(count))
                    {
                        if (!curveInfo[count].Contains(p1))
                            curveInfo[count].Add(p1);
                    }
                    else
                    {
                        if (zero)
                        {
                            curveInfo[count] = new List<(int, int)>();
                            curveInfo[count].Add(p1);
                        }
                    }

                    count++;
                }
            }

            return curveInfo;
        }

        // Установка изначальных параметров программы
        private void ParamsInstall()
        {
            string[] eParams = EPointATB.Text.Split(";");

            mod = int.Parse(eParams[0]);
            a = int.Parse(eParams[1]);
            b = int.Parse(eParams[2]);

            d[0] = int.Parse(SecretKeyATB.Text);
            d[1] = int.Parse(SecretKeyBTB.Text);           
        }

        // Обновление данных при изменении G точки
        private void ComboBoxUpdate(string gPointSelItem, int secretKey, TextBox OpenkeyTB)
        {
            string[] gPointText = gPointSelItem.Split(",");
            (int, int) gPointVal = (int.Parse(gPointText[0]), int.Parse(gPointText[1]));
            string p = Regex.Replace(SumPoints(gPointVal, secretKey, true).ToString(), @"\(|\)| +", "");

            OpenkeyTB.Text = "E" + mod.ToString() + ";" + a.ToString() + "," + b.ToString() +
                ";" + gPointSelItem + ";" + p.ToString();
        }

        // Получение и заполнение всех точек 13-го порядка
        private void UpdateBtnA_Click(object sender, EventArgs e)
        {
            ParamsInstall();
            
            List<(int, int)> points = CurveOrder();
            List<(int, int)> sPoints = SumPoints(points);
            Dictionary<int, List<(int, int)>> curveInfo = Order(sPoints);

            foreach ((int, int) val in curveInfo[13])
            {
                GPointABox.Items.Add(Regex.Replace(val.ToString(), @"\(|\)| +", ""));
                GPointBBox.Items.Add(Regex.Replace(val.ToString(), @"\(|\)| +", ""));
            }

            GPointABox.SelectedIndex = 4;
            GPointBBox.SelectedIndex = 4;

            UpdateBtnA.Enabled = false;
            UpdateBtnB.Enabled = false;
        }

        // Деление сообщения на блоки по 2 символа
        List<string> Divider(string str, int blockLength)
        {
            List<string> Blocks = new List<string>(str.Length / blockLength + 1);
            for (int i = 0; i < str.Length; i += blockLength)
            {
                Blocks.Add(str.Substring(i, str.Length - i > blockLength ? blockLength : str.Length - i));
            }
            return Blocks;
        }

        private void EncryptBtn_Click(object sender, EventArgs e)
        {   
            EncryptMessTB.Text = string.Empty;

            if (KeyCheckA.Checked)
                EncryptMessTB.Text = Encrypt(ToEcryptTB.Text, OpenkeyATB.Text);
            else
                EncryptMessTB.Text = Decrypt(ToEcryptTB.Text, SecretKeyATB.Text);
        }

        // Шифрование сообщения
        private string Encrypt(string text, string openKey)
        {
            char[] data = text.ToArray();
            List<(int, int)> dataPoints = new List<(int, int)>();
            string result = string.Empty;

            foreach (char val in data)
            {
                dataPoints.Add(alpha[val]);
            }

            Random rnd = new Random();

            foreach ((int, int) elem in dataPoints)
            {
                int k = rnd.Next(13);

                string[] ePoint = openKey.Split(";")[2].Split(",");
                (int, int) A = SumPoints((int.Parse(ePoint[0]), int.Parse(ePoint[1])), k, true);
                string A1 = alpha.Where(x => x.Value == A).FirstOrDefault().Key + "";

                ePoint = openKey.Split(";")[3].Split(",");
                (int, int) B = PointCalc(elem, SumPoints((int.Parse(ePoint[0]), int.Parse(ePoint[1])), k, true), true);
                string B1 = alpha.Where(x => x.Value == B).FirstOrDefault().Key + "";

                result += A1;
                result += B1;
            }

            return result;
        }

        // Расшифровка сообщения
        private string Decrypt(string text, string secretKey)
        {
            List<string> Blocks = Divider(text, 2);
            string res = string.Empty;

            foreach (string val in Blocks)
            {
                (int, int) A = alpha[val[0]];
                (int, int) B = alpha[val[1]];

                A = (A.Item1, Mod(-A.Item2, mod));

                (int, int) result = PointCalc(B, SumPoints(A, int.Parse(secretKey), true), true);

                string A1 = alpha.Where(x => x.Value == result).FirstOrDefault().Key + "";
                A1 = Regex.Replace(A1.ToString(), @"\(|\)| +", "");

                res += A1;
            }

            return res;
        }

        private void DecryptBtn_Click(object sender, EventArgs e)
        {
            DecryptMessTB.Text = string.Empty;

            if (KeyCheckB.Checked)
                DecryptMessTB.Text = Encrypt(ToDecryptTB.Text, OpenkeyBTB.Text);
            else 
                DecryptMessTB.Text = Decrypt(ToDecryptTB.Text, SecretKeyBTB.Text);
        }

        private void GPointABox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBoxUpdate(GPointABox.SelectedItem.ToString(), d[0], OpenkeyATB);
        }

        private void UpdateBtnB_Click(object sender, EventArgs e)
        {
            UpdateBtnA_Click(null, null);
        }

        private void SecretKeyBTB_TextChanged(object sender, EventArgs e)
        {
            if (SecretKeyBTB.Text != "")
            {
                d[1] = int.Parse(SecretKeyBTB.Text);
                ComboBoxUpdate(GPointBBox.SelectedItem.ToString(), d[1], OpenkeyBTB);
            }             
        }

        private void SecretKeyATB_TextChanged(object sender, EventArgs e)
        {
            if (SecretKeyATB.Text != "")
            {
                d[0] = int.Parse(SecretKeyATB.Text);
                ComboBoxUpdate(GPointABox.SelectedItem.ToString(), d[0], OpenkeyATB);
            }              
        }

        private void GPointBBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBoxUpdate(GPointBBox.SelectedItem.ToString(), d[1], OpenkeyBTB);
        }
    }
}