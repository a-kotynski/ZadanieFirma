Zadanie: Firma
Utwórz podstawy systemu zarządzania pracownikami w pewnej firmie. Zaimplementuj klasę reprezentującą pracownika.
Każdy pracownik opisany jest właściwościami:

* imię i nazwisko
* kontrakt

Klasa reprezentująca pracownika udostępnia operacje:

* konstruktor inicjujący pracownika o podanym w argumentach imieniu i nazwisku z domyślnym kontraktem stażysty
* metodę pozwalającą zmienić kontrakt przypisany do pracownika
* metoda zwracająca wysokość pensji pracownika uzależnionej od podpisanego kontraktu
* dociążoną metodę ToString() zwierającą łańcuch znakowy zawierający imię, nazwisko i wysokość pensji pracownika

Każdy kontrakt reprezentowany jest przez obiekt udostępniający publicznie następujące operacje:

* metodę o nazwie Pensja(), która zwraca wysokość pensji wypłacanej przy danym kontrakcie.
* konstruktor pozwalający zainicjować wszystkie pola składowe obiektu
* konstruktor domyślny

Obecnie w firmie podpisywane są 2 rodzaje kontraktów: staż i etat.

Kontrakty określone są przez następujące własności:

* Staż: stawka miesięczna (domyślnie 1000 zł)
* Etat: stawka miesięczna (domyślnie 5000 zł), ilość nadgodzin (domyślnie 0)

Wysokość pensji wyznaczana jest dla każdego z tych kontaktów inaczej, odpowiednio:

* Pensja stażysty równa jest stawce miesięcznej
* Pensja pracownika etatowego = stawka miesięczna + ilość nadgodzin * (stawka miesięczna/60)

Zakładamy, że w przyszłości pojawią się inne typy kontraktów różniące się sposobem naliczania 
wysokości pensji. Za obliczanie pensji odpowiedzialny jest obiekt klasy kontrakt, 
który udostępnia metodę publiczną zwracającą wysokość wynagrodzenia za pomocą metody Pensja(). 
Dlatego, dodanie nowego typu kontraktu sprowadza się do zaimplementowania tylko jednej klasy, 
bez potrzeby modyfikowania istniejących już klas.