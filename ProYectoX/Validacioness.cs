using System;
using Gtk;
namespace ProYectoX
{
    public class Validacioness
    {
        //variables globales
        public static int rol = 0;

        ///
        public Validacioness()
        {
        }
        //  ************PARA ADMITIR SOLO CARACTERES NUMERICOS***********                                                        
        public int[] RemoveIndices(int[] IndicesArray, int RemoveAt)
        {
            int[] newIndicesArray = new int[IndicesArray.Length - 1];

            int i = 0;
            int j = 0;
            while (i < IndicesArray.Length)
            {
                if (i != RemoveAt)
                {
                    newIndicesArray[j] = IndicesArray[i];
                    j++;
                }

                i++;
            }

            return newIndicesArray;
        }
        public void ValidarNum(Entry ent)
        {
            string cadena = ent.Text;
            int k;
            for (k = 0; k < cadena.Length; k++)
            { //si es un numero...

                if (cadena[k] >= '0' && cadena[k] <= '9')
                {
                }
                else  //entonces es otro caracter y debe eliminarlo..
                    ent.Text = cadena.Substring(0, cadena.Length - 1);
            }
        }

        //     *********** ADMITIR SOLO CARACTERES NUMERICOS Y SUSTITUIR (.) PUNTO POR (,) COMA**********                                   ||

        public void ValidarDecimal(Entry ent)
        {
            string cadena = ent.Text;
            int k;
            int cont = 0;
            for (k = 0; k < cadena.Length; k++)
            {

                if (cadena[k] >= '0' && cadena[k] <= '9' || cadena[k] == '.' || cadena[k] == ',')
                {

                    if (cadena[k] == ',' || cadena[k] == '.')
                    {

                        if (cont >= 1)
                        { //Verifica si hay punto decimal ya

                            ent.Text = cadena.Substring(0, cadena.Length - 1); //Si lo hay, elimina el punto que se intentó introducir

                        }
                        else if (cadena[k] == ',')
                        { //Si no hay punto decimal, verifica que se introduzca una coma

                            cont++; //Establece que hay comas en el entry

                        }
                        else if (cadena[k] == '.')
                        { //Si no hay punto decimal y se introduce un punto

                            ent.Text = cadena.Substring(0, cadena.Length - 1) + ','; //Se reemplaza el punto por una coma
                            cont++;
                        }
                    }
                }
                else //Si no es número ni coma
                    ent.Text = cadena.Substring(0, cadena.Length - 1); //Elimina ese caracter
            }
        }


        //        **********ADMITIR SOLO LETRAS DEL ALFABETO**********                                    ||
       
        public void ValidarLetras(Entry ent)
        {
            string cadena = ent.Text;
            int x;
            for (x = 0; x < cadena.Length; x++)
            {

                if (cadena[x] >= 'A' && cadena[x] <= 'Z' || cadena[x] >= 'a' && cadena[x] <= 'z' || cadena[x] == ' ')
                {
                } //Verifica que el caracter actual sea una letra mayúscula, minúscula o un espacio

                else
                    ent.Text = cadena.Substring(0, cadena.Length - 1); //Si no lo es, lo elimina
            }
        }
        //         **********ADMITIR SOLO CARACTERES ALFANUMERICOS **********                                                      ||
    

        public void ValidarAlfanum(Entry ent)
        {

            string cadena = ent.Text;
            int x;
            for (x = 0; x < cadena.Length; x++)
            {

                if (cadena[x] >= 'A' && cadena[x] <= 'Z' || cadena[x] >= 'a' && cadena[x] <= 'z' || cadena[x] == ' ' || cadena[x] >= '0' && cadena[x] <= '9')
                {
                } //Similar al anterior, pero también incluye números naturales
               
                else
                    ent.Text = cadena.Substring(0, cadena.Length - 1);
            }
        }
        public void espacios(Entry ent)
        {
            string cadena = ent.Text;
            int x;
            for (x = 0; x < cadena.Length; x++)
            {

                if (cadena[x] == ' ')
                {
                    ent.Text = cadena.Substring(0, cadena.Length - 1);
                } //Similar al anterior, pero también incluye números naturales

            }
        }



        //       **********METODOS PARA DIALOGOS**********                                                                             ||


        public void DialogOK(string aviso, string msj, string tipo)
        {
            //Se debe pasar por parámetro el titulo del dialog, el mensaje y el tipo.
            /*Los strings disponibles para el tipo son:
             * 
            -warning
            -info
            -error
            -pregunta

            NOTA:En el código de los parámetros este string se puede escribir en mayúsculas o minúsculas...
            */
            Dialog dialog = null;
            ResponseType response;
            try
            {
                dialog = new Dialog(
                    aviso,
                    dialog,
                    DialogFlags.DestroyWithParent | DialogFlags.Modal,
                    "OK", ResponseType.Ok
                );

                //PARA CONTROLAR EL ICONO DEL DIALOGO SEGUN EL TIPO...

                switch (tipo.ToLower())
                {
                    case "warning":
                        dialog.VBox.Add(new Image(Stock.DialogWarning, IconSize.Dialog));
                        break;
                    case "info":
                        dialog.VBox.Add(new Image(Stock.DialogInfo, IconSize.Dialog));
                        break;
                    case "error":
                        dialog.VBox.Add(new Image(Stock.DialogError, IconSize.Dialog));
                        break;
                    case "pregunta":
                        dialog.VBox.Add(new Image(Stock.DialogQuestion, IconSize.Dialog));
                        break;
                    case "autorizacion":
                        dialog.VBox.Add(new Image(Stock.DialogAuthentication, IconSize.Dialog));
                        break;

                    default:
                        dialog.VBox.Add(new Image(Stock.DialogInfo, IconSize.Dialog));
                        break;
                }

                dialog.VBox.Add(new Label(msj));
                dialog.ShowAll();

                response = (ResponseType)dialog.Run();
            }
            finally
            {
                if (dialog != null)
                    dialog.Destroy();
            }
        }

        public ResponseType DialogYESNO(string aviso, string opc1, string opc2, string msj)
        {

            /*ESTE METODO RETORNA UN RESPONSETYPE (es decir una respuesta de si o no)
             * 
             * AVISO: Titulo del dialog,
             * OPC1: OPCION 1 O YES,
             * OPC2:OPCION 2 O NO,
             * MSJ: MENSAJE DEL DIALOG
             * */
            Dialog dialog = null;
            ResponseType response = ResponseType.None;
            try
            {
                dialog = new Dialog(
                    aviso,
                    dialog,
                    DialogFlags.DestroyWithParent | DialogFlags.Modal,
                    opc1, ResponseType.Yes,
                    opc2, ResponseType.No
                );

                //SI SE QUIERE CAMBIAR EL ICONO ES EDITAR EL STOCK.DIALOG LOQUESEA)
                dialog.VBox.Add(new Image(Stock.DialogWarning, IconSize.Dialog));

                dialog.VBox.Add(new Label(msj));
                dialog.ShowAll();

                response = (ResponseType)dialog.Run();
            }
            finally
            {
                if (dialog != null)
                    dialog.Destroy();
            }
            return response;
        }

        public int searchArrayPosition(int[] arr, int value){
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == value)
                {
                    return i;
                }
            }
            return  - 1;
        }
       
        public int searchArrayPosition(string[] arr, string value)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i].ToString() == value.ToString())
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
