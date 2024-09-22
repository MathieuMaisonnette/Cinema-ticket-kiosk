using Google.Apis.Auth.OAuth2;
using Google.Apis.Services;
using Google.Apis.Sheets.v4.Data;
using Google.Apis.Sheets.v4;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;
using System.Threading;
using static Google.Apis.Requests.BatchRequest;
using Google.Apis.Gmail.v1;
using Google.Apis.Util.Store;
using MimeKit;
using System.Net;

namespace ProjetBorneCinema
{
    internal class GoogleSheets
    {

        static readonly string[] Scopes = { SheetsService.Scope.Spreadsheets };


        public static GoogleCredential GetCredential() //il y a un fichier json avec les clés de l'API près de l'exécutable qu'on consulte
        {
            GoogleCredential credential;
            using (var stream = new FileStream("api_google_sheets.json", FileMode.Open, FileAccess.Read))
            {
                credential = GoogleCredential.FromStream(stream).CreateScoped(Scopes);
            }
            //On obtient les credential nécessaires par la suite
            return credential;
        }


        public static string GetCellValue(string spreadsheetId, string sheetName, int rowIndex, int columnIndex)
        {
            SheetsService service = new SheetsService(new BaseClientService.Initializer
            {
                HttpClientInitializer = GetCredential(),
                ApplicationName = "Google-SheetsSample/0.1",
            });
            string range = sheetName + "!" + GetColumnName(columnIndex) + rowIndex;
            // Exécuter une requête pour lire la cellule
            SpreadsheetsResource.ValuesResource.GetRequest request = service.Spreadsheets.Values.Get(spreadsheetId, range);

            // Obtenir la réponse à la requête

            ValueRange response;

            bool reussi = false;
            do
            {
                try
                {
                    try
                    {
                        response = request.Execute();
                    } 
                    catch(System.Net.Http.HttpRequestException)//Sert juste à détecter une non connection à internet
                    {
                        MessageBox.Show("Connexion impossible à Internet, Redémarrez l'application", "Erreur grave", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Environment.Exit(0);//On force l'arrêt du programme
                        response = request.Execute();
                    }
                    reussi = true;
                    if (response.Values == null || response.Values.Count == 0)
                    {
                        return "vide";
                    }
                    else
                    {
                        return response.Values[0][0].ToString();
                    }
                }
                catch (Google.GoogleApiException)//L'api étant limité en nombre d'accès par minute on attent 1 seconde quand on dépasse le quota
                {
                    reussi = false;
                    Thread.Sleep(1000);
                }
            } while (!reussi);

            return "error";//On ne peut pas arriver jusqu'ici à cause du do while

        }

        public static void SetCellValue(string spreadsheetId, string sheetName, int rowstart, int columnstart, string texte)
        {
            SheetsService service = new SheetsService(new BaseClientService.Initializer
            {
                HttpClientInitializer = GetCredential(),
                ApplicationName = "Google-SheetsSample/0.1",
            });

            ValueRange valueRange = new ValueRange();
            var oblist = new List<object>() { texte };
            valueRange.Values = new List<IList<object>> { oblist };


            string range = sheetName + "!" + GoogleSheets.GetColumnName(columnstart) + rowstart.ToString();

            SpreadsheetsResource.ValuesResource.UpdateRequest update = service.Spreadsheets.Values.Update(valueRange, spreadsheetId, range);
            update.ValueInputOption = SpreadsheetsResource.ValuesResource.UpdateRequest.ValueInputOptionEnum.RAW;
            bool reussi = false;
            while(!reussi)
            try
            {
                UpdateValuesResponse result2 = update.Execute();
                    reussi = true;
            }
            catch(Google.GoogleApiException)
            {
                    reussi = false;
                    Thread.Sleep(1000);
            }


        }

        /*
        R : lit les valeurs dans un range d'un fichier gogle sheet
        E : spreadsheetId, nom de la sheet, ligne début, colonne début, ligne fin, colonne fin
        S : Liste 2 Dimensions contenant la valeur lue ou le string "vide" si il n'y avait RIEN
        */
        public static IList<IList<string>> GetCellValueRange(string spreadsheetId, string sheetName, int row_start, int column_start, int row_end, int column_end)
        {
            SheetsService service = new SheetsService(new BaseClientService.Initializer
            {
                HttpClientInitializer = GetCredential(),
                ApplicationName = "Google-SheetsSample/0.1",
            });

            string range = sheetName + "!" + GoogleSheets.GetColumnName(column_start) + row_start.ToString() + ":" + GoogleSheets.GetColumnName(column_end) + row_end.ToString();

            int i, j;
            int nbrcolonnes = row_end - row_start + 1;
            int nbrlignes = column_end - column_start + 1;
            var request = service.Spreadsheets.Values.Get(spreadsheetId, range);//il existe une requête spécifique pour sélectionner des valeurs
            //dans un intervalle (comme quand on sélectionne un tableau sur excel)
            var response = request.Execute();

            // Récupérer les valeurs dans un tableau multidimensionnel
            var values = response.Values;
            var result = new List<IList<string>>();

            var cellString = "vide";//Contiendra les valeurs stockées dans la liste
            for (i = 0; i< nbrcolonnes; i++)//On parcourt ttes les lignes
            {
                var rowData = new List<string>();
                for (j = 0; j < nbrlignes; j++) //On parcourt ttes les colonnes sur la ligne
                {
                        
                    try
                    {
                        if (values[i][j].ToString() != "")
                            cellString = values[i][j].ToString();
                        else
                            cellString = "vide";
                    }
                    catch (System.NullReferenceException)
                    {
                        cellString = "vide";
                    }
                    catch (System.ArgumentOutOfRangeException)
                    {
                        cellString = "vide";
                    }
                    rowData.Add(cellString);
                }
                result.Add(rowData);
            }
            return result;

            /*Maintenant les colonnes du Google sheet sont les lignes du tableau et les lignes du google sheet sont ses colonnes*/
        }

        public static string GetColumnName(int columnIndex)//convertit un numéro en la lettre de l'alphapet correspondante et qui est 
            //nécessaire dans l'adresse d'accès à une cellule google sheet
        {
            int dividend = columnIndex;
            string columnName = String.Empty;
            int modifier;

            while (dividend > 0)
            {
                modifier = (dividend - 1) % 26;
                columnName = Convert.ToChar(65 + modifier).ToString() + columnName;
                dividend = (int)((dividend - modifier) / 26);
            }

            return columnName;
        }


        /*
        public static void AddSheet(string spreadsheetId, string sheetName)//non utilisée, servait à l'époque où google sheet était notre base de donnée
            {
                SheetsService service = new SheetsService(new BaseClientService.Initializer
                {
                    HttpClientInitializer = GetCredential(),
                    ApplicationName = "Google-SheetsSample/0.1",
                });

                // Créer une nouvelle feuille
                var newSheet = new Sheet();
                newSheet.Properties = new SheetProperties
                {
                    Title = sheetName
                };

                // Ajouter la feuille au classeur
                BatchUpdateSpreadsheetRequest requestBody = new BatchUpdateSpreadsheetRequest();
                requestBody.Requests = new List<Request>
                {
                    new Request
                    {
                        AddSheet = new AddSheetRequest
                        {
                            Properties = newSheet.Properties
                          
                        }
                    }
                };
                var request = service.Spreadsheets.BatchUpdate(requestBody, spreadsheetId);

            bool reussi1 = false;
            while(!reussi1)
            {
                try
                {
                    var response = request.Execute();
                    reussi1 = true;
                }
                catch (Google.GoogleApiException)
                {
                    reussi1 = false;
                    Thread.Sleep(1000);
                }
            }
            
            

            BatchUpdateSpreadsheetRequest requestBod = new BatchUpdateSpreadsheetRequest();
            requestBod.Requests = new List<Request>();

            // Define the request to insert a new column
            Request reques = new Request();
            reques.InsertDimension = new InsertDimensionRequest();
            reques.InsertDimension.Range = new DimensionRange();
            try
            {
                //reques.InsertDimension.Range.SheetId = newSheet.Properties.SheetId;
                reques.InsertDimension.Range.SheetId = int.Parse(GetSheetId(spreadsheetId, sheetName));

            }
            catch(System.InvalidOperationException)
            {
                reques.InsertDimension.Range.SheetId = 0;

            }
                
            reques.InsertDimension.Range.Dimension = "COLUMNS";
            reques.InsertDimension.Range.StartIndex = 0;
            reques.InsertDimension.Range.EndIndex = 1;
            requestBod.Requests.Add(reques);

            // Update the sheet by executing the request

            bool reussi = false;
            for(int i =0; i<26;i++)
            {
                while(!reussi)
                {
                    try
                    {
                        BatchUpdateSpreadsheetResponse respons = service.Spreadsheets.BatchUpdate(requestBod, spreadsheetId).Execute();
                        reussi = true;
                    }
                    catch (Google.GoogleApiException)
                    {
                        reussi = false;
                        Thread.Sleep(1000);
                    }
                }
                reussi = false;
                
            }


        }*/
        /*
        public static string GetSheetId(string spreadsheetId, string sheetName) //non utilisée, servait à l'époque où google sheet était notre base de donnée
        {
            SheetsService service = new SheetsService(new BaseClientService.Initializer
            {
                HttpClientInitializer = GetCredential(),
                ApplicationName = "Google-SheetsSample/0.1",
            });
            var sheet = service.Spreadsheets.Get(spreadsheetId).Execute().Sheets.FirstOrDefault(s => s.Properties.Title == sheetName);
            if (sheet == null)
            {
                throw new Exception($"Sheet '{sheetName}' not found in spreadsheet '{spreadsheetId}'");
            }

            var sheetId = sheet.Properties.SheetId;
            return sheetId.ToString();
        }
        */
        /*
        public static void AddColumnToSheet(string spreadsheetId, int sheetId, string columnName)//non utilisée, servait à l'époque où google sheet était notre base de donnée
        {
            SheetsService service = new SheetsService(new BaseClientService.Initializer
            {
                HttpClientInitializer = GetCredential(),
                ApplicationName = "Google-SheetsSample/0.1",
            });

            BatchUpdateSpreadsheetRequest requestBody = new BatchUpdateSpreadsheetRequest();
            requestBody.Requests = new List<Request>();

            // Define the request to insert a new column
            Request request = new Request();
            request.InsertDimension = new InsertDimensionRequest();
            request.InsertDimension.Range = new DimensionRange();
            request.InsertDimension.Range.SheetId = sheetId;
            request.InsertDimension.Range.Dimension = "COLUMNS";
            request.InsertDimension.Range.StartIndex = 0;
            request.InsertDimension.Range.EndIndex = 1;
            requestBody.Requests.Add(request);

            // Update the sheet by executing the request

            bool reussi = false;
            while (!reussi)
            {
                try
                {
                    BatchUpdateSpreadsheetResponse response = service.Spreadsheets.BatchUpdate(requestBody, spreadsheetId).Execute();
                    reussi = true;
                }
                catch (Google.GoogleApiException)
                {
                    reussi = false;
                    Thread.Sleep(1000);
                }
            }

        }*/

    }
}
