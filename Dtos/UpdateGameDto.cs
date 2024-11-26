namespace GameStore.api.Dtos;

public record class UpdateGameDtoint( 
    string Name, 
    string Genre, 
    decimal Price,
    DateOnly ReleaseDate
    );
