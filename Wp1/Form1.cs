using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void go_Click(object sender, EventArgs e)
        {
            int a;
            a = int.Parse(tB1.Text);

            #region 假期公告
            if (go.Enabled == true)
            {
                switch (a)
                {
                    case 1:
                        
                            MessageBox.Show("1月假期為1.2.3", "查詢結果", MessageBoxButtons.OK);
                            this.pB1.Image = Image.FromFile("H:\\1.jpg");
                            break;
                        
                    case 2:
                       
                            MessageBox.Show("2月假期為10-16.27.28", "查詢結果", MessageBoxButtons.OK);
                            this.pB1.Image = Image.FromFile("H:\\2.jpg");
                            break;
                        
                    case 3: MessageBox.Show("3月無假期", "查詢結果", MessageBoxButtons.OK);
                        this.pB1.Image = Image.FromFile("H:\\3.jpg");
                        break;
                    case 4: MessageBox.Show("4月假期為2-5.30", "查詢結果", MessageBoxButtons.OK);
                        this.pB1.Image = Image.FromFile("H:\\4.jpg"); break;
                    case 5: MessageBox.Show("5月假期為1.2", "查詢結果", MessageBoxButtons.OK);
                        this.pB1.Image = Image.FromFile("H:\\5.jpg"); break;
                    case 6: MessageBox.Show("2月假期為12-14", "查詢結果", MessageBoxButtons.OK);
                        this.pB1.Image = Image.FromFile("H:\\6.jpg"); break;
                    case 7: MessageBox.Show("7月學生假期", "查詢結果", MessageBoxButtons.OK);
                        this.pB1.Image = Image.FromFile("H:\\7.8.jpg"); break;
                    case 8: MessageBox.Show("8月學生假期", "查詢結果", MessageBoxButtons.OK);
                        this.pB1.Image = Image.FromFile("H:\\7.8.jpg"); break;
                    case 9: MessageBox.Show("9月假期為18-21", "查詢結果", MessageBoxButtons.OK);
                        this.pB1.Image = Image.FromFile("H:\\9.jpg"); break;
                    case 10: MessageBox.Show("10月假期為9-11", "查詢結果", MessageBoxButtons.OK);
                        this.pB1.Image = Image.FromFile("H:\\10.jpg"); break;
                    case 11: MessageBox.Show("11月無假期", "查詢結果", MessageBoxButtons.OK);
                        this.pB1.Image = Image.FromFile("H:\\11.jpg"); break;
                    case 12: MessageBox.Show("12月假期為31.2022/1/1.2022/1/2", "查詢結果", MessageBoxButtons.OK);
                        this.pB1.Image = Image.FromFile("H:\\12.jpg"); break;
               
                    default:MessageBox.Show("查無結果" , "查詢結果", MessageBoxButtons.OK); break;
                

                        }
                }
            }
    }
    #endregion
    #region 假期圖示
    
    #endregion
}


