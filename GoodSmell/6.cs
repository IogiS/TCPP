void RefactoringFunctionForCheckDirectories() { 
foreach( DirectoryInfo dir in dirs.GetDirectories() ) { 
CheckDirectory(dir); 
} 
} 


void CheckDirectory(DirectoryInfo dir) { 
CreateFolder(); 
SendFolderName(); 
} 

void CreateFolder() { 
stream.Write( 
new byte[]{ (byte)NetworkMessage.MakeDir }, 
0,1 
); 
stream.Read( 
new byte[1], 
0,1 
); 
stream.Write( 
BitConverter.GetBytes( 
Encoding.UTF8.GetBytes(SubFolder.Replace('\\', '/') + dir.Name.Replace('\\', '/')).Length 
), 
0,4 
); 

stream.Write( 
Encoding.UTF8.GetBytes( 
SubFolder.Replace('\\', '/') + 
dir.Name.Replace('\\', '/') 
), 
0,Encoding.UTF8.GetBytes( 
SubFolder.Replace('\\', '/') + 
dir.Name.Replace('\\', '/') 
).Length 
); 
} 


void SendFolderName() { 
stream.Read( new byte[1], 0, 1 ); 
} 