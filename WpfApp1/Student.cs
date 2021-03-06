using System.ComponentModel;

namespace WpfApp1
{
    internal class Student : INotifyPropertyChanged  // 继承接口
    {
        private string name;
        //private string Name { get; set; } // 自动属性，相当于name字段加了get、set方法

        public event PropertyChangedEventHandler PropertyChanged;

        // 设置get、set方法，使用时Student.Name = XXX即调用set；XXX = Student.Name调用get
        public string Name
        {
            get { return name; }
            set
            {
                name = value;
                // 激发事件
                if (this.PropertyChanged != null)
                {
                    this.PropertyChanged.Invoke(this, new PropertyChangedEventArgs("Name"));
                }
            }
        }
    }
}