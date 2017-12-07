private void set_mode(bool mod)
{
 if(mod)
	ModTrue();
 else
	ModFalse();
}

private void ModTrue()
{
	label1.Enabled=true;
	button1.Enabled=true;
	button2.Enabled=true;
	button3.Enabled=false;
	button4.Enabled=false;
}

private void ModFalse()
{
	label1.Enabled=false;
	button1.Enabled=false;
	button2.Enabled=false;
	button3.Enabled=true;
	button4.Enabled=true;
}