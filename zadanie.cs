public class MyForm : Form
{
   Button button1;
   Button button2;
   Label label1;
   Label label2;
   CheckBox checkBox;

   public MyForm()
   {
       button1 = new Button() { Text = "Button 1", Location = new Point(10, 10) };
       button1.Click += ButtonClick;

       button2 = new Button() { Text = "Button 2", Location = new Point(10, 50) };
       button2.Click += ButtonClick;

       label1 = new Label() { Text = "Label 1", Location = new Point(100, 10) };
       label2 = new Label() { Text = "Label 2", Location = new Point(100, 50) };

       checkBox = new CheckBox() { Text = "Nacisnij mnie", Location = new Point(10, 90) };

       this.Controls.Add(button1);
       this.Controls.Add(button2);
       this.Controls.Add(label1);
       this.Controls.Add(label2);
       this.Controls.Add(checkBox);
   }

   private void ButtonClick(object sender, EventArgs e)
   {
       label1.Text = "Clicked at " + DateTime.Now.ToString();
       label2.Text = "Clicked at " + DateTime.Now.ToString();
   }

   [STAThread]
   public static void Main()
   {
       Application.Run(new MyForm());
   }
}
