using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OxyPlot;
using OxyPlot.Axes;
using OxyPlot.Series;

namespace Filter.GUI
{
    public partial class Histogram : Form
    {
        Bitmap firstBitmap, secondBitmap;
        PlotModel colorRmodel, colorGmodel, colorBmodel, blackRmodel, blackGmodel, blackBmodel;
        private List<DataPoint> redPoints = new List<DataPoint>(),
                                greenPoints = new List<DataPoint>(),
                                bluePoints = new List<DataPoint>(),
                                redPointsBlack = new List<DataPoint>(),
                                greenPointsBlack = new List<DataPoint>(),
                                bluePointsBlack = new List<DataPoint>();
        public Histogram(string RGBImage, string BWImage)
        {
            firstBitmap = new Bitmap(RGBImage);
            secondBitmap = new Bitmap(BWImage);
            InitializeComponent();
            PrepareModels();
            RcolorPlotView.Model = colorRmodel;
            GcolorPlotView.Model = colorGmodel;
            BcolorPlotView.Model = colorBmodel;
            RblackPlotView.Model = blackRmodel;
            GblackPlotView.Model = blackGmodel;
            BblackPlotView.Model = blackBmodel;
        }
        private void PrepareModels()
        {
            //values
            for (int i = 0; i <= 255; i++)
            {
                redPoints.Add(new DataPoint(i, 0));
                greenPoints.Add(new DataPoint(i, 0));
                bluePoints.Add(new DataPoint(i, 0));
                redPointsBlack.Add(new DataPoint(i, 0));
                greenPointsBlack.Add(new DataPoint(i, 0));
                bluePointsBlack.Add(new DataPoint(i, 0));
            }
            
            for(int i = 0; i < secondBitmap.Height; i++)
            {
                for(int j = 0; j < secondBitmap.Width; j++)
                {
                    var black = secondBitmap.GetPixel(j, i);
                    var color = firstBitmap.GetPixel(j, i);
                    // orignal R
                    var data = redPoints.First(x => x.X == color.R);
                    redPoints.Remove(data);
                    redPoints.Add(new (data.X, data.Y + 1));
                    // original G
                    data = greenPoints.First(x => x.X == color.G);
                    greenPoints.Remove(data);
                    greenPoints.Add(new(data.X, data.Y + 1));
                    //original B
                    data = bluePoints.First(x => x.X == color.B);
                    bluePoints.Remove(data);
                    bluePoints.Add(new(data.X, data.Y + 1));
                    // edited R
                    data = redPointsBlack.First(x => x.X == black.R);
                    redPointsBlack.Remove(data);
                    redPointsBlack.Add(new(data.X, data.Y + 1));
                    // edited G
                    data = greenPointsBlack.First(x => x.X == black.G);
                    greenPointsBlack.Remove(data);
                    greenPointsBlack.Add(new(data.X, data.Y + 1));
                    //edited B
                    data = bluePointsBlack.First(x => x.X == black.B);
                    bluePointsBlack.Remove(data);
                    bluePointsBlack.Add(new(data.X, data.Y + 1));
                }
            }
            redPoints.Sort((a,b)=> a.X.CompareTo(b.X));
            greenPoints.Sort((a,b)=> a.X.CompareTo(b.X));
            bluePoints.Sort((a,b)=> a.X.CompareTo(b.X));
            redPointsBlack.Sort((a,b)=> a.X.CompareTo(b.X));
            greenPointsBlack.Sort((a,b)=> a.X.CompareTo(b.X));
            bluePointsBlack.Sort((a,b)=> a.X.CompareTo(b.X));

            //models prepare
            colorRmodel = colorfulRModel();
            colorGmodel = colorfulGModel();
            colorBmodel = colorfulBModel();
            blackRmodel = colorlessRModel();
            blackGmodel = colorlessGModel();
            blackBmodel = colorlessBModel();
        }
        private PlotModel colorfulRModel() {
            //model
            PlotModel model = new PlotModel();
            model.Title = "kolor czerowny";
            model.Subtitle = "Originalne zdięcie";
            model.Background = OxyColor.FromRgb(245, 222, 179);
            //axis
            var linearAxis1 = new LinearAxis() { Title = "wartość koloru czerownego" };
            linearAxis1.Position = AxisPosition.Bottom;
            model.Axes.Add(linearAxis1);
            var linealAxis2 = new LinearAxis() { Title = "ilość pikseli" };
            linealAxis2.Position = AxisPosition.Left;
            model.Axes.Add(linealAxis2);
            //series
            var series = new AreaSeries() { ItemsSource = redPoints };
            series.Color = OxyColor.FromRgb(255, 0, 0);
            model.Series.Add(series);

            return model;
        }
        private PlotModel colorfulGModel() {
            //model
            PlotModel model = new PlotModel();
            model.Title = "kolor zielony";
            model.Subtitle = "Originalne zdięcie";
            model.Background = OxyColor.FromRgb(245, 222, 179);
            //axis
            var linearAxis1 = new LinearAxis() { Title = "wartość koloru zielonego" };
            linearAxis1.Position = AxisPosition.Bottom;
            model.Axes.Add(linearAxis1);
            var linealAxis2 = new LinearAxis() { Title = "ilość pikseli" };
            linealAxis2.Position = AxisPosition.Left;
            model.Axes.Add(linealAxis2);
            //series
            var series = new AreaSeries() { ItemsSource = greenPoints };
            series.Color = OxyColor.FromRgb(0, 255, 0);
            model.Series.Add(series);

            return model;
        }
        private PlotModel colorfulBModel() {
            //model
            PlotModel model = new PlotModel();
            model.Title = "kolor niebieski";
            model.Subtitle = "Originalne zdięcie";
            model.Background = OxyColor.FromRgb(245, 222, 179);
            //axis
            var linearAxis1 = new LinearAxis() { Title = "wartość koloru niebieskiego" };
            linearAxis1.Position = AxisPosition.Bottom;
            model.Axes.Add(linearAxis1);
            var linealAxis2 = new LinearAxis() { Title = "ilość pikseli" };
            linealAxis2.Position = AxisPosition.Left;
            model.Axes.Add(linealAxis2);
            //series
            var series = new AreaSeries() { ItemsSource = bluePoints };
            series.Color = OxyColor.FromRgb(0, 0, 255);
            model.Series.Add(series);

            return model;
        }
        private PlotModel colorlessRModel() {
            //model
            PlotModel model = new PlotModel();
            model.Title = "kolor czerowny";
            model.Subtitle = "czarnobiałe zdięcie";
            model.Background = OxyColor.FromRgb(245, 222, 179);
            //axis
            var linearAxis1 = new LinearAxis() { Title = "wartość koloru czerownego" };
            linearAxis1.Position = AxisPosition.Bottom;
            model.Axes.Add(linearAxis1);
            var linealAxis2 = new LinearAxis() { Title = "ilość pikseli" };
            linealAxis2.Position = AxisPosition.Left;
            model.Axes.Add(linealAxis2);
            //series
            var series = new AreaSeries() { ItemsSource = redPointsBlack };
            series.Color = OxyColor.FromRgb(255, 0, 0);
            model.Series.Add(series);

            return model;
        }
        private PlotModel colorlessGModel()
        {
            //model
            PlotModel model = new PlotModel();
            model.Title = "kolor zielony";
            model.Subtitle = "czarnobiałe zdięcie";
            model.Background = OxyColor.FromRgb(245, 222, 179);
            //axis
            var linearAxis1 = new LinearAxis() { Title = "wartość koloru zielonego" };
            linearAxis1.Position = AxisPosition.Bottom;
            model.Axes.Add(linearAxis1);
            var linealAxis2 = new LinearAxis() { Title = "ilość pikseli" };
            linealAxis2.Position = AxisPosition.Left;
            model.Axes.Add(linealAxis2);
            //series
            var series = new AreaSeries() { ItemsSource = greenPointsBlack };
            series.Color = OxyColor.FromRgb(0, 255, 0);
            model.Series.Add(series);

            return model;
        }
        private PlotModel colorlessBModel()
        {
            //model
            PlotModel model = new PlotModel();
            model.Title = "kolor niebieksi";
            model.Subtitle = "czarnobiałe zdięcie";
            model.Background = OxyColor.FromRgb(245, 222, 179);
            //axis
            var linearAxis1 = new LinearAxis() { Title = "wartość koloru niebieskiego" };
            linearAxis1.Position = AxisPosition.Bottom;
            model.Axes.Add(linearAxis1);
            var linealAxis2 = new LinearAxis() { Title = "ilość pikseli" };
            linealAxis2.Position = AxisPosition.Left;
            model.Axes.Add(linealAxis2);
            //series
            var series = new AreaSeries() { ItemsSource = bluePointsBlack };
            series.Color = OxyColor.FromRgb(0, 0, 255);
            model.Series.Add(series);

            return model;
        }
    }
}
