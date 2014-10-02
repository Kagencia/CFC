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

namespace CFC.Views
{
    /// <summary>
    /// Follow steps 1a or 1b and then 2 to use this custom control in a XAML file.
    ///
    /// Step 1a) Using this custom control in a XAML file that exists in the current project.
    /// Add this XmlNamespace attribute to the root element of the markup file where it is 
    /// to be used:
    ///
    ///     xmlns:MyNamespace="clr-namespace:CFC.Views"
    ///
    ///
    /// Step 1b) Using this custom control in a XAML file that exists in a different project.
    /// Add this XmlNamespace attribute to the root element of the markup file where it is 
    /// to be used:
    ///
    ///     xmlns:MyNamespace="clr-namespace:CFC.Views;assembly=CFC.Views"
    ///
    /// You will also need to add a project reference from the project where the XAML file lives
    /// to this project and Rebuild to avoid compilation errors:
    ///
    ///     Right click on the target project in the Solution Explorer and
    ///     "Add Reference"->"Projects"->[Browse to and select this project]
    ///
    ///
    /// Step 2)
    /// Go ahead and use your control in the XAML file.
    ///
    ///     <MyNamespace:ListBoxItemEX/>
    ///
    /// </summary>
    public class ListBoxItemEX : Control
    {
        static ListBoxItemEX()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(ListBoxItemEX), new FrameworkPropertyMetadata(typeof(ListBoxItemEX)));
        }

        public static readonly DependencyProperty ItemNameProperty = DependencyProperty.Register("ItemName", typeof(string), typeof(ListBoxItemEX), new PropertyMetadata(String.Empty));
        public static readonly DependencyProperty ItemPriceProperty = DependencyProperty.Register("ItemPrice", typeof(string), typeof(ListBoxItemEX), new PropertyMetadata("R$ 00,00"));
        public static readonly DependencyProperty IsTotalProperty = DependencyProperty.Register("IsTotal", typeof(bool), typeof(ListBoxItemEX), new PropertyMetadata(false));

        public static readonly DependencyProperty IsSelectedProperty = DependencyProperty.Register("IsSelected", typeof(bool), typeof(ListBoxItemEX), new PropertyMetadata(false));


        public string ItemName
        {
            get { return (string)GetValue(ItemNameProperty); }
            set { SetValue(ItemNameProperty, value); }
        }

        public string ItemPrice
        {
            get { return (string)GetValue(ItemPriceProperty); }
            set { SetValue(ItemPriceProperty, value); }
        }

        public bool IsTotal
        {
            get { return (bool)GetValue(IsTotalProperty); }
            set { SetValue(IsTotalProperty, value); }
        }

        public bool IsSelected
        {
            get { return (bool)GetValue(IsSelectedProperty); }
            set { SetValue(IsSelectedProperty, value); }
        }

        protected override void OnMouseDown(MouseButtonEventArgs e)
        {
            this.IsSelected = true;
            foreach(Control el in (Parent as StackPanel).Children)
            {
                if (el.GetType() == typeof(ListBoxItemEX) && el != this)
                    (el as ListBoxItemEX).IsSelected = false;
            }
            base.OnMouseDown(e);
        }
    }
}
