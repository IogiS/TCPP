string mailTo = CreateMailto(); 

string CreateMailto() { 
if(MailtoCondition()) { 
return Globals.GetHostPortalSettings().HostSettings["SMTPPassword"].ToString(); 
} else { 
return Config.GetSetting("AdminNotifications_EmailAddress"); 
} 
} 

bool MailtoCondition() { 
return ( 
(Config.GetSetting("AdminNotifications_EmailAddress") == null) || 
(Config.GetSetting("AdminNotifications_EmailAddress").Length <= 0) 
); 
} 