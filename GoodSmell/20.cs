public bool CheckPath(string path) 
{ 
int n = 0; 

//��������� ������� ������ �����; 
foreach( string neededDir in NEEDED_DIRECTORIES_ARRAY) { 
if( Directory.Exists(path + neededDir) ) n++; 
} 

//��������� ������� ������ ������ 
foreach( string neededFile in NEEDED_FILES_ARRAY) { 
if( File.Exists(path + neededfile) ) n++; 
} 

//���� ��������� ����� �������� ���, ��� ����� 
if(n == NEEDED_COUNT) 
{ 
return true; 
} 
return false; 
} 