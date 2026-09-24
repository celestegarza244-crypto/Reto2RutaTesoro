# Reto 2 – La Ruta del Tesoro Perdido

WinForms app (C#, .NET 8) that simulates a treasure route using a **singly
linked list built entirely from scratch** (no `List<T>`, `LinkedList<T>`,
`Queue<T>`, `Stack<T>`, `Dictionary<TKey,TValue>`, or arrays used as storage).



AUTORES: 
-ALEXA ABIGAIL FRAIRE SANDOVAL
-CELESTE ANYELIQUE GARZA MAURICIO 

## Project structure

```
Reto2RutaTesoro/
├── Node.cs                    -> the linked list node (Id, Name, Clue, Danger, Next)
├── SimpleLinkedList.cs        -> the linked list logic (Insert, Search, Modify, Delete, traversal)
├── FrmRutaTesoro.cs           -> form logic (event handlers only call SimpleLinkedList)
├── FrmRutaTesoro.Designer.cs  -> WinForms designer-generated UI layout
├── Program.cs                 -> app entry point
└── Reto2RutaTesoro.csproj     -> .NET 8 WinForms project file
```

## How to run it

1. Install the .NET 8 SDK (Windows) if you don't have it: https://dotnet.microsoft.com/download/dotnet/8.0
2. Open `Reto2RutaTesoro.csproj` in Visual Studio 2022+ (or run `dotnet run`
   from this folder on Windows).
3. Press F5 / Run.

## What the app does

- Starts with 4 sample locations already loaded into the linked list
  (Shipwreck Beach, Kraken's Cave, Skull Island, Lost Temple).
- **Insert at End / Insert at Beginning**: adds a new node using the ID,
  Name, Clue and Danger Level (1-10) fields.
- **Search by ID**: walks the list from Head to null looking for a match,
  loads its data into the form and highlights the row in the grid.
- **Modify Selected ID**: finds the node by ID and updates its fields
  in place (no node is removed/re-created).
- **Delete by ID**: removes the node by re-linking its neighbors, after a
  confirmation prompt.
- **Clear Form**: resets the input fields.
- Clicking a row in the `DataGridView` loads that node's data back into the
  form for quick editing.
- After every insert/modify/delete, the grid is fully rebuilt by traversing
  the linked list from `Head` to `null` - the grid is a **view only**, never
  a storage mechanism.

## Notes on the "from scratch" restriction

- `SimpleLinkedList` only keeps a private `head` reference; every other node
  is reached by following `Next` pointers.
- The `foreach (Node node in route)` traversal used to fill the grid is
  implemented with a custom `IEnumerator<Node>` (`yield return`) that walks
  the chain node-by-node - it does not copy the data into any prohibited
  collection type.
- Button click handlers (`btnAddEnd_Click`, `btnDelete_Click`, etc.) never
  touch node internals directly; they only call public methods on
  `SimpleLinkedList` (`InsertAtEnd`, `Delete`, `Modify`, `Search`), matching
  the required flow: `btnEliminar_Click -> ListaSimple.Eliminar(id) ->
  node manipulation -> refresh grid`.

> The original challenge PDF specifies .NET 10 / Visual Studio 2026; this
> project targets **.NET 8** as requested. To upgrade, just change
> `<TargetFramework>net8.0-windows</TargetFramework>` to
> `net10.0-windows` in the `.csproj` once that SDK is available to you.
