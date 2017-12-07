public bool CheckPath(string path) 
{ 
int n = 0; 

//Проверяем наличие нужных папок; 
foreach( string neededDir in NEEDED_DIRECTORIES_ARRAY) { 
if( Directory.Exists(path + neededDir) ) n++; 
} 

//Проверяем наличие нужных файлов 
foreach( string neededFile in NEEDED_FILES_ARRAY) { 
if( File.Exists(path + neededfile) ) n++; 
} 

//Если указанная папка содержит все, что нужно 
if(n == NEEDED_COUNT) 
{ 
return true; 
} 
return false; 
} 