using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace P4_LAB14
{
    class RegisterCommand : ICommand
    {
        private RegistrationModelValidator _validator = new RegistrationModelValidator();
        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }
        public bool CanExecute(object parameter)
        {
            var model = parameter as RegistrationModel;
            if (model is null)
            {
                return false;
            }
            var results = _validator.Validate(model);
            model.Errors = string.Join(", ", results.Errors);
            return results.IsValid;
        }

        public void Execute(object parameter)
        {
            var model = parameter as RegistrationModel;
            MessageBox.Show($"Zarejestrowano użytkownika {model.Email}", "rejestracja przebiegła pomyślnie", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}
