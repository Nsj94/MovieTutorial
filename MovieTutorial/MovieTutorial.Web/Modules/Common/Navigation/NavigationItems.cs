using Serenity.Navigation;
using Administration = MovieTutorial.Administration.Pages;

[assembly: NavigationLink(1000, "Dashboard", url: "~/", permission: "", icon: "fa-tachometer")]
[assembly: NavigationMenu(2000, "Movie Database", icon: "fa-film")]
[assembly: NavigationLink(2100, "Movie Database/Movies",typeof(MovieTutorial.Default.Pages.MovieController), icon: "fa-video-camera")]
[assembly: NavigationLink(2200, "Movie Database/Genre", typeof(MovieTutorial.Default.Pages.GenreController), icon: "fa-thumb-tack")]

