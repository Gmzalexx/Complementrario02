namespace Complementrario02;

public partial class AB : ContentPage
{
	public AB()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
        // Luego de haber hecho un evento en el button vamos a obtener los valores de A y B que nos
        //Estan pidiendo en la app
        if (double.TryParse(entryA.Text, out double a) && double.TryParse(entryB.Text, out double b))
        {
            // Luego calculamos el resultado de la expresión que hemos escrito con el double haciendo una 
            //suma entre a y b luego multiplicandolo para luego dividirlo
            double resultado = ((a + b) * (a + b)) / 2;

            // Mostramos el resultado en el Label que nos va aparecer en la pantalla de la app
            resultLabel.Text = $"El resultado es: {resultado}";
        }
        else
        {
            // Y por si los valores no estan bien escritos o mal ingresados
            // Mostramos un mensaje de error para que el usuario ingrese bien los datos
            resultLabel.Text = "Por favor, ingrese valores numéricos válidos para A y B.";
        }
    }
}