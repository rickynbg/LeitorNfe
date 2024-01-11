# LeitorNfe

Projeto ASP Net. Core MVC, para fazer operações CRUD com arquivos NFe XML

- Usando dotnet 8.0

- Entity framework 8.0


#### ToDo:

* [ ] Test suite xunit
* [ ] Cards para mostrar detalhes das notas
* [ ] Remover arquivos sem usar do */wwwroot/*
* [ ] Remover warnings de possiveis null references

## Executar localmente

```bash
dotnet ef migrations add InitialCreate
dotnet ef database update

dotnet watch run
```