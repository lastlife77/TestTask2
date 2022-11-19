using GMap.NET;
using GMap.NET.WindowsForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tusk2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DataStream dataStream = new DataStream();
        public bool streamPoint = true;
        PointLatLng lastPoint;


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void gMapControl1_Load(object sender, EventArgs e)
        {
            GMap.NET.GMaps.Instance.Mode = GMap.NET.AccessMode.ServerAndCache; 
            gMapControl1.MapProvider = GMap.NET.MapProviders.GoogleMapProvider.Instance; 
            gMapControl1.MinZoom = 2;
            gMapControl1.MaxZoom = 16; 
            gMapControl1.Zoom = 3; 
            gMapControl1.Position = new GMap.NET.PointLatLng(66.4169575018027, 94.25025752215694);
            gMapControl1.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter; 
            gMapControl1.CanDragMap = true; 
            gMapControl1.DragButton = MouseButtons.Left; 
            gMapControl1.ShowCenter = false; 
            gMapControl1.ShowTileGridLines = false;
        }


        
        public void paintLine(PointLatLng point1, PointLatLng point2)
        {
            GMapOverlay polyOverlay = new GMapOverlay("polygons");
            List<PointLatLng> points = new List<PointLatLng>();
            points.Add(point1);
            points.Add(point2);
            GMapPolygon polygon = new GMapPolygon(points, "mypolygon"); 
            polygon.Fill = new SolidBrush(Color.FromArgb(50, Color.Red));
            polygon.Stroke = new Pen(Color.Red, 1);
            polyOverlay.Polygons.Add(polygon);
            gMapControl1.Overlays.Add(polyOverlay);
        }

        public void stream()
        {
            //PointLatLng point = new PointLatLng(55.7522, 37.6156); москва
            PointLatLng point = dataStream.genStartPoint();
            PointLatLng prevPoint;
            while (streamPoint)
            {
                prevPoint = point;
                point = dataStream.genRandomPoint(prevPoint);
                paintLine(prevPoint, point);
                lastPoint = point;
                Thread.Sleep(200);
            }
        }

        async Task streamAsync()
        {
            await Task.Run(() => stream());
        }

        public async void buttonStartDataStream_Click_1(object sender, EventArgs e)
        {
            streamPoint = true;
            labelSensor.Text = "Работает";
            labelSensor.ForeColor = Color.Green;
            await streamAsync();
            labelSensor.Text = "Остановлен";
            labelSensor.ForeColor = Color.Red;
        }

        private void buttonStopDataStream_Click(object sender, EventArgs e)
        {
            streamPoint = false;
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            gMapControl1.Overlays.Clear();
            gMapControl1.Zoom = 10;
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            gMapControl1.Zoom = 10;
            gMapControl1.Position = lastPoint;
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
