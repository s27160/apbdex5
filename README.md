# VetClinic - REST API
## Opis
VetClinic to aplikacja REST API stworzona na potrzeby zarządzania danymi zwierząt w bazie danych schroniska dla kliniki weterynaryjnej. API umożliwia wykonywanie podstawowych operacji CRUD na danych zwierząt oraz zarządzanie wizytami weterynaryjnymi.
## Funkcjonalności
### Zarządzanie zwierzętami
- Pobieranie listy wszystkich zwierząt
- Pobieranie danych konkretnego zwierzęcia po ID
- Wyszukiwanie zwierząt po imieniu
- Dodawanie nowych zwierząt
- Edycja danych zwierząt
- Usuwanie zwierząt

### Zarządzanie wizytami
- Pobieranie listy wizyt dla konkretnego zwierzęcia
- Dodawanie nowych wizyt dla zwierzęcia

## Modele danych
### Zwierzę (Animal)
- Id: int
- Name: string - imię zwierzęcia
- Category: string - kategoria (np. pies, kot)
- Weight: double - masa
- FurColor: string - kolor sierści

### Wizyta (Visit)
- Id: int
- AnimalId: int - identyfikator zwierzęcia
- Date: DateTime - data wizyty
- Description: string - opis wizyty
- Price: decimal - cena wizyty

## Endpoints API
### Zarządzanie zwierzętami
- `GET /api/v1/animals` - pobieranie wszystkich zwierząt
- `GET /api/v1/animals/{id}` - pobieranie zwierzęcia po ID
- `GET /api/v1/animals/{name}` - wyszukiwanie zwierząt po imieniu
- `POST /api/v1/animals` - dodawanie nowego zwierzęcia
- `PUT /api/v1/animals/{id}` - aktualizacja danych zwierzęcia
- `DELETE /api/v1/animals/{id}` - usuwanie zwierzęcia

### Zarządzanie wizytami
- `GET /api/v1/animals/{animalId}/visits` - pobieranie wszystkich wizyt dla zwierzęcia
- `POST /api/v1/animals/{animalId}/visits` - dodawanie nowej wizyty dla zwierzęcia

## Technologie
- .NET 9.0
- Postman
- Swagger/OpenAPI

## Uruchomienie aplikacji
1. Sklonuj repozytorium
2. Otwórz projekt w Visual Studio lub JetBrains Rider
3. Uruchom aplikację
4. Otwórz przeglądarkę i przejdź do `https://localhost:port/swagger` aby zobaczyć dokumentację API

## Testowanie
Aplikacja została wyposażona w Swagger UI, który umożliwia testowanie wszystkich endpointów bezpośrednio z przeglądarki. Dodatkowo, zaleca się korzystanie z narzędzia Postman do dokładniejszego testowania API.
