# Lista Zadań

Tematem projektu jest stworzenie interaktywnej listy zadań z wykorzystaniem technologii WPF 

## Autorzy

* Grzegorz Andrzejowski
* Bartosz Chowaniak

## Etapy projektu

1. Możliwość Obejrzenia listy przykładowych zadań oraz wyświetlenia szczegółów wybranego zadania 
2. Wykonywanie operacji CRUD wobec poszczególnych zadań
3. Zapis listy zadań do pliku xml oraz jej odczyt
4. Sortowanie listy zadań
5. Filtrowanie listy zadań
6. Inne(?)

## Workflow

* Lista tasków znajduje się na trello. Członek zespołu wybiera task z kolumny "do wzięcia", przypisuje do siebie i przenosi jego kartę do kolumny "In Dev"
* Tworzy feature branch
* Po zaprogramowaniu nowych funkcjonalności, i upewnieniu się że:
  1) Funkcjonalność działa poprawnie
  2) Nowe funkcjonalności i zmiany w starych pokryte są testami jednostkowymi
  3) Testy przechodzą

  członek zespołu otwiera pull request, przenosi kartę tasku do kolumny "Code Review" i przypisuje do innego członka zespołu
* Jeżeli w ciągu jednego dnia nie ma obiekcji ze strony recenzenta (lub wcześniej pull request zostanie pozytywnie zaopiniowany) autor dołącza kod do gałęzi "master"
* Karta tasku zostaje przeniesiona do kolumny "Zrobione"
