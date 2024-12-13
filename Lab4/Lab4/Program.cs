namespace Lab4
{
	using System;

	// Lớp Window cơ bản
	class Window
	{
		// Các trường dữ liệu top và left
		public int top;
		public int left;

		// Constructor của Window
		public Window(int top, int left)
		{
			this.top = top;
			this.left = left;
		}

		// Phương thức DrawWindow
		public virtual void DrawWindow()
		{
			Console.WriteLine($"Drawing a window at position (Top: {top}, Left: {left})");
		}
	}

	// Lớp Button kế thừa từ Window
	class Button : Window
	{
		// Constructor của Button
		public Button(int top, int left) : base(top, left)
		{
		}

		// Ghi đè phương thức DrawWindow
		public override void DrawWindow()
		{
			Console.WriteLine($"Drawing a button at position (Top: {top}, Left: {left})");
		}
	}

	// Lớp ListBox kế thừa từ Window
	class ListBox : Window
	{
		// Trường dữ liệu mới: content
		public string content;

		// Constructor của ListBox
		public ListBox(int top, int left, string content) : base(top, left)
		{
			this.content = content;
		}

		// Ghi đè phương thức DrawWindow
		public override void DrawWindow()
		{
			Console.WriteLine($"Drawing a listbox at position (Top: {top}, Left: {left}) with content: {content}");
		}
	}

	// Lớp chính Program để kiểm thử
	class Program
	{
		static void Main(string[] args)
		{
			// Tạo đối tượng Window
			Window window = new Window(10, 20);
			window.DrawWindow();

			// Tạo đối tượng Button và gọi phương thức ghi đè
			Button button = new Button(5, 15);
			button.DrawWindow();

			// Tạo đối tượng ListBox và gọi phương thức ghi đè
			ListBox listBox = new ListBox(2, 8, "Sample Content");
			listBox.DrawWindow();

			Console.ReadKey(); // Đợi nhấn phím để kết thúc chương trình
		}
	}

}
