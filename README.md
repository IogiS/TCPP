Âñòðàèâàíèå ìåòîäà
void PrintStudentReport(void)
{
 PrinReportTitle();
if(NumberOfStudentsIsMoreTheanHundred())
   cout<<"We have a lot of students here";
else
   cout<<"Where are the students??!!11";
 

<<"Donetsk National University"<< endl;
}

bool NumberOfStudentsIsMoreThanHundred(void)
{
 return students.size() > 100;
}

Refactoring------------------------------------------------
void PrintStudentReport(void)
{
 PrinReportTitle();
if(students.size() >100)
   cout<<"We have a lot of students here";
else
   cout<<"Where are the students??!!11";
 

<<"Donetsk National University"<< endl;
}

double GetRating(void)
{
double professorsSize = 0;
for_each(teachers.begin(), teachers.end();
}
___________________________________________________________
âñòðàèâàíèå âðåìåííîé ïåðåìåííîé
bool NumberOf StudentsIsMoreThanHundred(void)
{

int numberOfStudents = students.size();
return numberOfStudents >100;
}

Refactoring--------------------------------------------------
bool NumberOfStudentsIsMoreThanHundred(void)
{
  return students.size() > 100;
}
_______________________________________________________-
 Çàìåíà âðåìåííîé ïåðåìåííîé âûçîâîì ìåòîäà
 double GetRatind(void)
{

double professorsSize =0;
 for_each(teachers.begin(), teachers.end(),[&professorsSize] (TEacher*t)
{
 if(t-> IsProfessor())
++professorSize;
});
++professorsSize;
});
double techersPercent = teachers.size() / student.size();
double professorsPersent = professorsSize / teachers.size();
return teachersPercent+professorsPersetn;
}

Refactoring--------------------------------------

double GetRating(void)
{ 
double professorsSize = 0;
++prosessorsSize;
});
double professorsPercent = professorsSize / teachers.size();
return TeachersPercent() + professorsPercent;
}
______________________________________________________
Ââåäåíèå ïîÿñíÿþùåé ïåðåìåííîé
double GetRating(void)
{
 if(t-> IS professor())
 ++professorsSize;
});
return teachers.size()/ student.size()+ professorSize/ teachers.size();
}
 
Refactoring--------------------------------------------------

 double GetRating(void)
{
   if(t-> ISprofessor())
    ++ professorsSize;
});

double teachersPercent = teachers.size() / student.size();
double professorsPercent = professorsSize / teachers.size();
 return teachersPercent+ professorsPercent;
_____________________________________________________
Çàìåíà âðåìåííîé ïåðåìåííîé
double temp = _width*_height;
cout<<"square:"<<temp;

temp=2*(_width+_height);
cout<<"Perimeter:"<<temp;

Refactoring-------------------------------------
double square =_width*_height;
cout<<"Square:"<<square;

double perimetr=2*(_width+_height);
cout<<"Perimetr:"<<perimetr;
______________________________________________________
Óäàëåíèå ïðèñâàèâàíèé ïàðàìåòðàì
double discount( double price, int quantity ) {
         if ( price > 1000.0 ) {
                   price *= 0.9;
         }
         if ( quantity >= 5 ) {
                   price *= 0.8;
         }
         return price;
}
 
Refactoring----------------------------------------

double discount( double price, int quantity ) {
        double result = price;
        
         if ( price > 1000.0 ) {
                   result *= 0.9;
         }
         if ( quantity >= 5 ) {
                   result *= 0.8;
         }
         return result;
}
_____________________________________________________
Äåêîìïîçèöèÿ óñëîâíîãî îïåðàòîðà
if (date.before (SUMMER_START) || date.after(SUMMER.END)) charge = quantity * _winterRate + _wlnterServiceCharge; 
else charge = quantity • _summerRate;

Refactoring----------------------------------------

if (notSu'mmer(date)) charge = winterCharge(quantity);
 else charge = summerCharge (quantity);
_____________________________________________________
Êîíñîëèäàöèÿ äóáëèðóþùèõñÿ óñëîâíûõ ôðàãìåíòîâ
if(isSpecialDeal()) { 
total = price * 0.95; 
send();
}
else{
total = price * 0.98;
send();
}

Refactoring----------------------------------------

if(isSpecialDeal()) 
total = price * 0.95; 
else
total = price * 0.98; 
send();
_____________________________________________________
Êîíñîëèäàöèÿ óñëîâíîãî âûðàæåíèÿ
double disabilityAmountO {
 if (_seniority < 2) return 0;
 if CmonthsDisabled > 12) 
	return 0; 
 if (_isPartTime) 
	return 0; // compute the disability amount

Refactoring----------------------------------------

double disabilityAmount() {
 if (isNotEligableForDisabilityO) 
	return 0: // compute the disability amount
_____________________________________________________
Óäàëåíèå óïðàâëÿþùåãî ôëàãà
void checkSecurity(String[] people) 
{ 
	boolean found = false
 for (int i=0, l < people length, i++)
 { 
	if (' found) 
 { 	if (people[i] equals ( Don"))
 { 	sendAlert()
 	found = true 
 } if (people[i] equals ("John")){ sendAlert(), found = true}

Refactoring----------------------------------------

void checkSecunty(String[] people) 
{ boolean found = false 
for (int i=0 l < people length i++)
 { if (' found) 
{ if (people[i] equals ( Don )){ sendAlert() break > if (people[i] equals ( John )){ sendAlertO found = true } } } }
_____________________________________________________
Ïîäúåì ïîëÿ, ìåòîäà
class Animal
{
public:
	virtual void vote();
};

class Dog : public Animal
{
public:
	void vote() override;
	void getStatusDog();
	
private:
	std::string status_;
};

class Bird : public Animal
{
public:
	void vote() override;
	void getStatusBird();
	
private:
	std::string status_;
};

Refactoring----------------------------------------

class Animal
{
public:
	virtual void vote();
	void getStatus();
	
private:
	std::string status_;
};

class Dog : public Animal
{
public:
	void vote() override;
	void getStatus() override;
};

class Bird : public Animal
{
public:
	void vote() override;
	void getStatus() override;
};

_____________________________________________________
Ñïóñê ïîëÿ, ìåòîäà
class Unit
{
public:
	void getFuel();
	...
	
private:
	int fuel_;
	...
};

class Solider : public Unit
{
	...
};

class Tank : public Unit
{
	...
};

Refactoring----------------------------------------

class Unit
{
public:
	...
	
private:
	...
};

class Solider : public Unit
{
	...
};

class Tank : public Unit
{
public:
	void getFuel();

private:
	int fuel_;
};
