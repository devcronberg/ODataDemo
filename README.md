# ODataDemo

OData demo (Core 3.1) der benytter [SQLite - people.db](https://github.com/devcronberg/undervisning-db-sqlite).

Prøv evt

https://localhost:44314/api/people
https://localhost:44314/api/people?$top=5&$count=true
https://localhost:44314/api/people?$top=5&$skip=5&$count=true
https://localhost:44314/api/people?$select=firstname,lastname
https://localhost:44314/api/people?$orderby=Height
https://localhost:44314/api/people?$filter=FirstName eq 'Florence'
https://localhost:44314/api/people?$filter=(height lt 180) and (countryid eq 1)
https://localhost:44314/api/people?$filter=startswith(FirstName,'Co')
https://localhost:44314/api/people?$filter=contains(FirstName, 'ee')
https://localhost:44314/api/people(1)

Se evt https://www.odata.org/getting-started/basic-tutorial/
