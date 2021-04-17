# Generate-Json-and-qr-code-for-e-invoice---India
This application will help you to create json and QR for the E-Invoice. 

How it work.
1. Generate Json 
2. open E-Invoice portal and will upload the json file
3. it will download the excelsheet
4. generate QR code from excelsheet
5. update the QR code to invoice table

Important note :
kindly checkt he below code and understand it 

 string Current_path = System.IO.Directory.GetCurrentDirectory();
            string connectionString = System.IO.File.ReadAllText(Current_path + @"\Connection.txt");
            
            string DownloadPath = System.IO.File.ReadAllText(Current_path + @"\Download_Path.txt");
            
            string QRDownloadPath = System.IO.File.ReadAllText(Current_path + @"\QRDownloadPath.txt");
            
            string ExcelSourcePath = System.IO.File.ReadAllText(Current_path + @"\ExcelSourcePath.txt");
            
            string SQL_Script = System.IO.File.ReadAllText(Current_path + @"\SQL_Script.txt");
            
            string CompletedPath = System.IO.File.ReadAllText(Current_path + @"\CompletedPath.txt");
            
            string PendingPath = System.IO.File.ReadAllText(Current_path + @"\PendingPath.txt");
            
            string UpdateTableName = System.IO.File.ReadAllText(Current_path + @"\UpdateTableName.txt");
            
            string QRCodeSize = System.IO.File.ReadAllText(Current_path + @"\QRCodeSize.txt");
            
            string downloadDirectory = System.IO.File.ReadAllText(Current_path + @"\ExceldownloadDirectory.txt");
            
            string Url = System.IO.File.ReadAllText(Current_path + @"\Url.txt");
            
            string dir = System.IO.File.ReadAllText(Current_path + @"\Download_Path.txt");
            
            string uploadURL = System.IO.File.ReadAllText(Current_path + @"\uploadURL.txt");
            
            string username = System.IO.File.ReadAllText(Current_path + @"\username.txt");
            
            string password = System.IO.File.ReadAllText(Current_path + @"\password.txt");
