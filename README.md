# ArenaPhysics
## Кратко обобщение на проекта
### Идея на прокта
- Да се създаде оценяваща платформа за задачи по физика
- Да се създаде лесна комуникация между състезателите
- Да се покажат различни методи за решаване на дадена задача по физика
### Трудности по създаване на проекта
- Извършване на справедлива проверка (формулите могат да се записват по различни начини)
- Начин на записване на формулите (как да се интегрира редактор във фронтенда)
- Добавяне на всички задачи от всички състезания (времеемка задача)
### Разрешаване на трудностите
- Формулите да се записват по определен утвърден стандарт (безразмерна константа умножена с величина от търсената размерност)
- Използване на LaTeX
- Създаване на админска роля, която може да добавя задачите директно през сайта, без да се хардкоудват задачите
## Разширена обосновка на проекта
### Архитектура
- Проекта е построен на базата на трислойния модел 
- За framework използвам .Net 6.0
- Базата данни е реализирана чрез MySQL 
- За ORM (комуникация с базата данни) е използван EntityFrameworkCore
- За тестинг на API endpoint-ите е използван Swagger (вграден в .Net Web API)
- Фронтенд да жалост няма :( (но щеше да бъде написан на react.js + bootstrap)
### База данни
- Базата данни е доста лека, липсата на много обекти прави базата данни лесна за осъществяване
- Имаме 4 основни таблици (Users, Comments, Problems, UserProblems) и 2 свързващи (UserComments, ProblemComments)
Users:
Id VARCHAR PK
UserName VARCHAR
Email VARCHAR
FirstName VARCHAR
LastName VARCHAR
Age INT
DateOfCreation DATE
ProblemsPoints FLOAT
NumberOfProblemsSolved INT
+ допълнителни колони за статистика за потребителя (които все още не са интегрирани в проекта

Comments:
Id INT PK
Content VARCHAR 

Problems:
Id INT PK
Branches ENUM (...branches...)
Difficulty ENUM (...difficulties...)
Author (...authors...)
ProblemCode VARCHAR (номер на задачата от темата)
Year INT (година на провеждане)
Grade INT (предназначена за кой клас)
CompetitionName ENUM (...competitions...) 
ProblemFileName VARCHAR (име на файла със задачата)
AdditionalInformation VARCHAR (допълнителна информация за задачата)
NumberOfFormulas INT (брой на формулите носещи точки)
PointsDistribution VARCHAR (как се разпределят точките по формулите записано във формат "2|6|2|....")
Answer VARCHAR (отговор на задачата записан във формат "formula1|formula2|...")
OfficialAnswers VARCHAR (име на файла с отговора за задачата)

UserProblems: (таблица с информация за решението на конкретен потребител за някоя задача)
UserId VARCHAR 
ProblemId INT
Points FLOAT
PointsDistribution VARCHAR (как се разпределят точките по формулите записано във формат "2|6|2|....")
IsSolved BOOLEAN
UserAnswer VARCHAR (отговор на задачата записан във формат "formula1|formula2|...")
UserAnswerFileName VARCHAR (име на файла с отговора за задачата от потребителя само ако е решил всичко)

UserComments:
UserId VARCHAR
CommentId INT

ProblemComments:
ProblemId INT
CommentId INT

### API ENDPOINTS
/api/Auth/Login [POST] - endpoint за вход на потребителите
/api/Auth/Register [POST] - endpoint за регистрация на потребителите

/api/Comment/Problem/{problemId} [GET] - endpoint за виждане на всички коментари по една конкретна задача
/api/Comment/{commentId} [GET] - endpoint за виждане на конкретен коментар
/api/Comment [POST] - endpoint за създаване на коментар от определен потребител под определена задача
/api/Comment{id} [PUT] - endpoint за редакция на коментар
/api/Comment{id} [DELETE] - endpoint за изтриване на коментар

/api/Problem/{id} [GET] - endpoint за виждане на конкретна задача
/api/Problem/{id} [PUT] - endpoint за редакция на задача - ПОЗВОЛЕНО САМО ЗА АДМИНСКА РОЛЯ
/api/Problem [POST] - endpoint за създаване на задача - ПОЗВОЛЕНО САМО ЗА АДМИНСКА РОЛЯ

/api/UserProblem/{id} [GET] - endpoint за извличане на резултатите от проверяващата система
/api/UserProblem/{id} [PUT] - endpoint за повторен опит за решаване на задачата
/api/UserProblem [POST] - endpoint за опит за решаване на задачата

### SECURITY
- Използвам JWT token, който се подава при аутентикация на потребителя.
- След 1 час този токен се инвалидира и потребителя трябва да се аутентикира отново.
- Има 2 роли - потребител и админ, админът има допълнителни права да създава задачи

### FRONTEND PAGES (ARCHITECTURE)
- index.html -----> 1), 2), 3), 4)
-1) problem-maker.html (post api endpoint for Problem) [САМО ЗА АДМИНСКИ ДОСТЪП]
0) login/register.html (api endpoints for Authentication)
1) rules-of-use.html
2) contact.html
3) user-menu.html
4) ranking.html
5) competitions.html ----> 5.1) National Olympiad, .... 
5.1) nat-olymp.html ----> 5.1.1) year 2023, .....
5.1.1) year-2023.html ----> 5.1.1.1) class 12, ....  
5.1.1.1) class-12.html ----> 5.1.1.1.1) problem1, 5.1.1.1.2) problem2, ....
5.1.1.1.1) problem1.html ----> бутон изпрати решение препращащ към нова страница problem1-ans, скрити коментари под задачата (потребителя може да ги разкрие -> api endpoints for Comments)
5.1.1.1.1.1) problem1-ans ----> бутон за изпращане на решението правещ запис в базата данни (api endpoints for UserProblem)

## Поле за подобрение
- Добавяне на user-friendly фронтенд
- Добавяне на допълнителни възможни записи на формули, което да олесни потребителя със записа му на формула
- Добавяне на endpoint позволяваш изтеглянето на решенията на потребителите за съответната задача (полето UserAnswerFileName)
- Добавяне на ранглиста, която утилизира статистиката събирана в таблицата Users


*Недовършен проект, но моя идея от дълго време, която евентуално ще бъде осъществена!*
От Георги Костадинов (състезател по физика)





