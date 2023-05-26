API – CRUD dla dodania planu treningowego oraz partii ciała
Projekt jest aplikacją do planowania treningu siłowego. Możemy dodać, edytować oraz usunąć ćwiczenia do planu treningowego.
Projekt został zrealizowany przy pomocy .Net 6 na back-endzie, EntityFrameworkCore spina back-end z bazą danych Sql server.
Aplikacja realizuje podstawowe operacje CRUD – zapis, odczyt, edycja oraz usuwanie.
W relacyjnej bazie danych mamy dwie tabelki – główna do zapisu ćwiczeń w planie z kluczem obcym prowadzącym do drugiej tabelki słownikowej w której trzymamy ”partie ciała”

Zastosowane wzorce:
- Depencency Injection (wstrzykiwanie zależności)
- Repository Pattern – całą akcję z kontrolerów przenieśliśmy do repozytoriów, które dziedziczą z interfejsów
- CQRS (Command and Query Responsibility Segregation) – wzorzec pozwalający oddzielić operacje odczytu i zapisu/modyfikacji.
 Wraz z CQRSem dodaliśmy MediatR – „szynę komunikacyjną” która świetnie sprawdza się w tym podejściu.








