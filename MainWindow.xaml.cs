using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using HelixToolkit.Wpf;
using System.Windows.Media.Media3D;
using System.Text.RegularExpressions;
using System.Reflection;
using System.Security.Policy;
using System.Threading;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Messaging;

namespace wpftest3d
{

    public partial class MainWindow : Window
    {
        Model3D model1;
        Model3D model2;
        Model3D model3;
        Model3D model4;
        Model3D model5;
        Model3D model6;
        Model3D model7;
        Model3D model8;
        Model3D model9;
        Model3D model10;

        public MainWindow()
        {
            InitializeComponent();
            ModelImporter importer = new ModelImporter();

            //камера
            OrthographicCamera camera = new OrthographicCamera();
            camera.Position = new Point3D(0, 2.5, 5);
            camera.LookDirection = new Vector3D(0, -2.5, -5);
            camera.Width = 1.5;
            viewport.Camera = camera;

            //МОДЕЛИ
            //Альметьевск
            model1 = importer.Load("D:/3D/TATNEFT/MapOtdelno/almet.obj");
            ModelUIElement3D UImodel1 = new ModelUIElement3D();
            UImodel1.Model = model1;
            viewport.Children.Add(UImodel1);
            UImodel1.MouseEnter += MouseEnter1;
            UImodel1.MouseLeave += MouseLeave1;

            //Азнакаево
            model2 = importer.Load("D:/3D/TATNEFT/MapOtdelno/aznakaev.obj");
            ModelUIElement3D UImodel2 = new ModelUIElement3D();
            UImodel2.Model = model2;
            viewport.Children.Add(UImodel2);
            UImodel2.MouseEnter += MouseEnter2;
            UImodel2.MouseLeave += MouseLeave2;

            //Бавлы
            model3 = importer.Load("D:/3D/TATNEFT/MapOtdelno/bavlinsk.obj");
            ModelUIElement3D UImodel3 = new ModelUIElement3D();
            UImodel3.Model = model3;
            viewport.Children.Add(UImodel3);
            UImodel3.MouseEnter += MouseEnter3;
            UImodel3.MouseLeave += MouseLeave3;
            //Джалиль
            model4 = importer.Load("D:/3D/TATNEFT/MapOtdelno/djalil.obj");
            ModelUIElement3D UImodel4 = new ModelUIElement3D();
            UImodel4.Model = model4;
            viewport.Children.Add(UImodel4);
            UImodel4.MouseEnter += MouseEnter4;
            UImodel4.MouseLeave += MouseLeave4;
            //Елхов
            model5 = importer.Load("D:/3D/TATNEFT/MapOtdelno/elhov.obj");
            ModelUIElement3D UImodel5 = new ModelUIElement3D();
            UImodel5.Model = model5;
            viewport.Children.Add(UImodel5);
            UImodel5.MouseEnter += MouseEnter5;
            UImodel5.MouseLeave += MouseLeave5;
            //Призрак
            model6 = importer.Load("D:/3D/TATNEFT/MapOtdelno/ghost.obj");
            ModelUIElement3D UImodel6 = new ModelUIElement3D();
            UImodel6.Model = model6;
            viewport.Children.Add(UImodel6);
            //Лениногорск
            model7 = importer.Load("D:/3D/TATNEFT/MapOtdelno/lensk.obj");
            ModelUIElement3D UImodel7 = new ModelUIElement3D();
            UImodel7.Model = model7;
            viewport.Children.Add(UImodel7);
            UImodel7.MouseEnter += MouseEnter7;
            UImodel7.MouseLeave += MouseLeave7;
            //Нурлат
            model8 = importer.Load("D:/3D/TATNEFT/MapOtdelno/nurlat.obj");
            ModelUIElement3D UImodel8 = new ModelUIElement3D();
            UImodel8.Model = model8;
            viewport.Children.Add(UImodel8);
            UImodel8.MouseEnter += MouseEnter8;
            UImodel8.MouseLeave += MouseLeave8;
            //Прикам
            model9 = importer.Load("D:/3D/TATNEFT/MapOtdelno/prikam.obj");
            ModelUIElement3D UImodel9 = new ModelUIElement3D();
            UImodel9.Model = model9;
            viewport.Children.Add(UImodel9);
            UImodel9.MouseEnter += MouseEnter9;
            UImodel9.MouseLeave += MouseLeave9;
            //Ямаш
            model10 = importer.Load("D:/3D/TATNEFT/MapOtdelno/yamash.obj");
            ModelUIElement3D UImodel10 = new ModelUIElement3D();
            UImodel10.Model = model10;
            viewport.Children.Add(UImodel10);
            UImodel10.MouseEnter += MouseEnter10;
            UImodel10.MouseLeave += MouseLeave10;
        }
        //Альметьевск
        public void MouseEnter1(object sender, MouseEventArgs e)
        {
            var TransModel = model1;
            TransModel.Transform = new TranslateTransform3D(0, 0, -0.05);
        }
        public void MouseLeave1(object sender, MouseEventArgs e)
        {
            var TransModel = model1;
            TransModel.Transform = new TranslateTransform3D(0, 0, 0);
        }
        //Азнакаево
        public void MouseEnter2(object sender, MouseEventArgs e)
        {
            var TransModel = model2;
            TransModel.Transform = new TranslateTransform3D(0, 0, -0.05);
        }
        public void MouseLeave2(object sender, MouseEventArgs e)
        {
            var TransModel = model2;
            TransModel.Transform = new TranslateTransform3D(0, 0, 0);
        }
        //Бавлы
        public void MouseEnter3(object sender, MouseEventArgs e)
        {
            var TransModel = model3;
            TransModel.Transform = new TranslateTransform3D(0, 0, -0.05);
        }
        public void MouseLeave3(object sender, MouseEventArgs e)
        {
            var TransModel = model3;
            TransModel.Transform = new TranslateTransform3D(0, 0, 0);
        }
        //Джалиль
        public void MouseEnter4(object sender, MouseEventArgs e)
        {
            var TransModel = model4;
            TransModel.Transform = new TranslateTransform3D(0, 0, -0.05);
        }
        public void MouseLeave4(object sender, MouseEventArgs e)
        {
            var TransModel = model4;
            TransModel.Transform = new TranslateTransform3D(0, 0, 0);
        }
        //Елхов
        public void MouseEnter5(object sender, MouseEventArgs e)
        {
            var TransModel = model5;
            TransModel.Transform = new TranslateTransform3D(0, 0, -0.05);
        }
        public void MouseLeave5(object sender, MouseEventArgs e)
        {
            var TransModel = model5;
            TransModel.Transform = new TranslateTransform3D(0, 0, 0);
        }
        //Лениногорск
        public void MouseEnter7(object sender, MouseEventArgs e)
        {
            var TransModel = model7;
            TransModel.Transform = new TranslateTransform3D(0, 0, -0.05);
        }
        public void MouseLeave7(object sender, MouseEventArgs e)
        {
            var TransModel = model7;
            TransModel.Transform = new TranslateTransform3D(0, 0, 0);
        }
        //Нурлат
        public void MouseEnter8(object sender, MouseEventArgs e)
        {
            var TransModel = model8;
            TransModel.Transform = new TranslateTransform3D(0, 0, -0.05);
        }
        public void MouseLeave8(object sender, MouseEventArgs e)
        {
            var TransModel = model8;
            TransModel.Transform = new TranslateTransform3D(0, 0, 0);
        }
        //Прикам
        public void MouseEnter9(object sender, MouseEventArgs e)
        {
            var TransModel = model9;
            TransModel.Transform = new TranslateTransform3D(0, 0, -0.05);
        }
        public void MouseLeave9(object sender, MouseEventArgs e)
        {
            var TransModel = model9;
            TransModel.Transform = new TranslateTransform3D(0, 0, 0);
        }
        //Ямаш
        public void MouseEnter10(object sender, MouseEventArgs e)
        {
            var TransModel = model10;
            TransModel.Transform = new TranslateTransform3D(0, 0, -0.05);
        }
        public void MouseLeave10(object sender, MouseEventArgs e)
        {
            var TransModel = model10;
            TransModel.Transform = new TranslateTransform3D(0, 0, 0);
        }
    }
}


