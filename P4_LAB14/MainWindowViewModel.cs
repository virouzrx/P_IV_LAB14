using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace P4_LAB14
{
    public class MainWindowViewModel
    {
        public MainWindowViewModel()
        {
            Registration = new RegistrationModel();
            RegisterCommand = new RegisterCommand();
        }
        public RegistrationModel Registration { get; set; }
        public ICommand RegisterCommand { get; set; }
    }
}
