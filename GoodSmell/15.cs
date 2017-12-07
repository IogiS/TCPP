public string generateEMail()
{
string res;
res = PersonName;
res = res.Replace(' ','.');
if(res.Length > 20)
{
	res = res.Substring(0,19);
}
res += "@domain.ua";
return res;
}

	   