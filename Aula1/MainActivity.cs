using Android.App;
using Android.Widget;
using Android.OS;

namespace Aula1
{
    [Activity(Label = "Aula1", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.Main);
            Button btnConverter = FindViewById<Button>
                (Resource.Id.btnconverter);
            EditText txtDolares = FindViewById<EditText>
                (Resource.Id.txtdolares);
            EditText txtPeso = FindViewById<EditText>
                (Resource.Id.txtpesos);
            double pesos, dolares;
            btnConverter.Click += delegate
            {
                try
                {
                    dolares = double.Parse(txtDolares.Text);
                    pesos = dolares * 19.5;
                    txtPeso.Text = pesos.ToString();
                }
                catch (System.Exception ex)
                {
                    Toast.MakeText(this, ex.Message,
                        ToastLength.Short).Show();
                    throw;
                }
            };
            
        }
    }
}

