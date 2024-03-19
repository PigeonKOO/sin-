using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace sin그래프
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitializeChart();
        }

        private void InitializeChart()
        {
            // Chart 초기 설정
            chart1.Series.Clear(); // 기존 시리즈를 제거
            chart1.Series.Add("sin"); // 새 시리즈 추가
            chart1.Series["sin"].ChartType = SeriesChartType.Line; // 차트 타입을 선 그래프로 설정
        }

        private void button1_Click(object sender, EventArgs e)
        {
            chart1.Series["sin"].Points.Clear(); // 그래프를 새로 그리기 전에 기존 포인트를 지웁니다.

            for (double x = 0; x <= 2200; x += 1)
            {
                double y = Math.Sin(x * Math.PI / 180); // 라디안 단위로 변환
                chart1.Series["sin"].Points.AddXY(x, y);
            }
        }

        private void erase_Click(object sender, EventArgs e)
        {
            chart1.Series["sin"].Points.Clear(); // 시리즈의 모든 포인트를 지웁니다.
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
    }
}