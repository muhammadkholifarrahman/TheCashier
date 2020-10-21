# The Cashier Apps
Aplikasi ini berfungsi untuk membantu kita dalam mendata barang sekaligus harganya
cocok digunakan untuk dikasir karena dapat mendata barang belanjaan 

## Scope & Functionalities
- User dapat memasukkan angka
- User dapat memasukkan barang
- User dapat info barang sekaligus harganya sekaligus

## How Does it Works?
 Diawali dari method MainWindow

```csharp
 public partial class MainWindow : Window
    {
        private Calculator calculator;
        public MainWindow()
        {
            InitializeComponent();
            calculator = new Calculator();
            listBox.ItemsSource = calculator.getListItem();
        }
```
logika perhitungannya terdapat pada class AddButton_Click. Sebagai berikut

```csharp
private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            string title = itemNameBox.Text;
            int quantity = int.Parse(quantityBox.Text);
            string type = typeBox.Text;
            double price = double.Parse(priceBox.Text);

            Item item = new Item(new Random().Next(), title, quantity, price, type);
            calculator.addItem(item);
            double total = calculator.getTotal();

            totalLabel.Content = String.Format("Rp. {0}", total);

            listBox.Items.Refresh();

        }
```

Cara kerjanya kita hanya memasukkan data sesuai dengan data yang diminta misal diminta barang dan harganya tinggal dimasukkan datanya lalu data tersebut akan disimpan di list box yang telah disediakan.