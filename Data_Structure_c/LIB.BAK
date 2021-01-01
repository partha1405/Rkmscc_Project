#include<stdio.h>
#include<conio.h>
typedef struct stu
{
int book_id,isbn;
char book_nm[100],auth_nm[100],publ[100],edt[20],dt_isu[30];
struct stu *next;
}stu1;
stu1 *start;
void create(stu1 *);
void display(stu1 *);
void dele_any();
void dele1st();
void delelst();
stu1 * ins1st();
void inslst();
void insmid();
void search();
void main()
{
int i=0;
clrscr();
start=(stu1 *)malloc(sizeof(stu1));
do
{
printf("1. Create\n");
printf("2. Display\n");
printf("3. Insert data at first\n");
printf("4. Insert data at last\n");
printf("5. Insert data at middle\n");
printf("6. Delete first row\n");
printf("7. Delete last row\n");
printf("8. Delete from middle\n");
printf("9. Exit\n");
printf("Enter your choice :- ");
scanf("%d",&i);
switch(i)
{
case 1:
create(start);
break;
case 2:
display(start);
break;
case 3:
start=ins1st();
break;
case 4:
inslst();
break;
case 5:
insmid();
break;
case 6:
dele1st();
break;
case 7:
delelst();
break;
case 8:
dele_any();
break;
case 9:
exit(0);
}
}while(1);
}
void create(stu1 *node)
{
char ans='y';
clrscr();
node->next=(stu1 *)malloc(sizeof(stu1));
printf("\nEnter book id :- ");
scanf("%d",&node->book_id);
printf("\nEnter book's name :- ");
fflush(stdin);
gets(node->book_nm);
printf("\nEnter author's name :-");
fflush(stdin);
gets(node->auth_nm);
printf("\nEnter publication's name :- ");
fflush(stdin);
gets(node->publ);
printf("\nEnter edition :- ");
fflush(stdin);
gets(node->edt);
printf("\nEnter date :- ");
fflush(stdin);
gets(node->dt_isu);
printf("\nEnter isbn no :- ");
scanf("%d",&node->isbn);
printf("\nDo you want to continue (Y/N)? ");
fflush(stdin);
ans=getchar();
if(ans=='y' || ans=='Y')
{
node->next=(stu1 *)malloc(sizeof(stu1));
create(node->next);
}
else
node->next=NULL;
}
void display(stu1 *node)
{
int no=0;
//node=start->next;
while(node)
{
printf("Book id :- %d Book Name :- %s Author's Name :- %s Publication :- %s Edition :- %s Date :- %s ISBN :- %d\n",node->book_id,node->book_nm,node->auth_nm,node->publ,node->edt,node->dt_isu,node->isbn);
node=node->next;
no++;
}
}
void dele_any()
{
stu1 *prev,*node;
int no=1,nod=0;
prev=start;
node=start->next;
printf("\n\nEnter position no for delete operation :- ");
scanf("%d",&nod);
while(node)
{
if(no==nod-1)
{
prev->next=node->next;
free(node);
break;
}
prev=prev->next;
node=node->next;
no++;
}
printf("%d position number recorded deleted",nod);
getch();
}
void dele1st()
{
stu1 *node;
node=start;
start=node->next;
free(node);
printf("First record deleted\n");
getch();
return start;
}
void delelst()
{
stu1 *prev, *node;
prev=start;
node=start;
while(node)
{
if(node->next==NULL)
{
prev->next=node->next;
free(node);
break;
}
else
{
prev=node;
node=node->next;
}
}
printf("Last record deleted...");
getch();
}
stu1 * ins1st()
{
stu1 *node,*new1;
node=start;
new1=(stu1 *)malloc(sizeof(stu1));
new1->next=node;
printf("\nEnter new book id :- ");
scanf("%d",&new1->book_id);
printf("\nEnter new book's name :- ");
fflush(stdin);
gets(new1->book_nm);
printf("\nEnter author's name :-");
fflush(stdin);
gets(new1->auth_nm);
printf("\nEnter publication's name :- ");
fflush(stdin);
gets(new1->publ);
printf("\nEnter edition :- ");
fflush(stdin);
gets(new1->edt);
printf("\nEnter date :- ");
fflush(stdin);
gets(new1->dt_isu);
printf("\nEnter isbn no :- ");
scanf("%d",&new1->isbn);
start=new1;
return start;
}
void inslst()
{
}
void insmid()
{
stu1 *prev, *node, *new1;
int no=0, p=0;
prev=start;
node=start->next;
printf("\nEnter position no :- ");
scanf("%d",&p);
while(node)
{
no++;
if(no==p)
{
new1=(stu1 *)malloc(sizeof(stu1));
printf("\nEnter new book id :- ");
scanf("%d",&new1->book_id);
printf("\nEnter new book's name :- ");
fflush(stdin);
gets(new1->book_nm);
printf("\nEnter author's name :-");
fflush(stdin);
gets(new1->auth_nm);
printf("\nEnter publication's name :- ");
fflush(stdin);
gets(new1->publ);
printf("\nEnter edition :- ");
fflush(stdin);
gets(new1->edt);
printf("\nEnter date :- ");
fflush(stdin);
gets(new1->dt_isu);
printf("\nEnter isbn no :- ");
scanf("%d",&new1->isbn);
new1->next=node;
prev->next=new1;
break;
}
else
{
prev=prev->next;
node=node->next;
}
}
}
void search()
{
}