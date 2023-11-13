namespace Projekt_Kremer.Data
{
    public class MockDB
    {

        public List<PlantCardDTO> Data { get; set; } = new List<PlantCardDTO>()
        {
            new PlantCardDTO()
            {
                Id =1,
            Title = "Title 1",
            Content = "Content 1",
            ImageURL = "https://s3.amazonaws.com/images.ecwid.com/images/20892833/1240776484.jpg",
                IsFavorite = true
            },
            new PlantCardDTO()
            {
                Id =2,
            Title = "Title 2",
            Content = "Content 2",
            ImageURL = "https://s3.amazonaws.com/images.ecwid.com/images/20892833/1240776484.jpg"
            },
            new PlantCardDTO()
            {
                Id =3,
            Title = "Title 3",
            Content = "Content 3",
            ImageURL = "https://s3.amazonaws.com/images.ecwid.com/images/20892833/1240776484.jpg"
            },
            new PlantCardDTO()
            {
                Id =4,
            Title = "Title 4",
            Content = "Content 4",
            ImageURL = "https://s3.amazonaws.com/images.ecwid.com/images/20892833/1240776484.jpg"
            }
        };
    }
}
