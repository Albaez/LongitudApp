using System.ComponentModel;
using System.ComponentModel.Design;
using System.Runtime.CompilerServices;


namespace LongitudApp
{
    public class KmToMViewModel : INotifyPropertyChanged
    {
        private double valorKm;
        private double resultado;

        public event PropertyChangedEventHandler PropertyChanged;

        public double ValorKm
        {
            get { return valorKm; }
            set
            {
                if (valorKm != value)
                {
                    valorKm = value;
                    OnPropertyChanged();
                }
            }
        }

        public double Resultado
        {
            get { return resultado; }
            set
            {
                if (resultado != value)
                {
                    resultado = value;
                    OnPropertyChanged();
                }
            }
        }

        public CommandID ConvertirKmCommand { get; }

        public KmToMViewModel()
        {
            ConvertirKmCommand = new CommandID (ConvertirKm);
        }

        private void ConvertirKm()
        {
            Resultado = ValorKm * 1000;
        }

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
