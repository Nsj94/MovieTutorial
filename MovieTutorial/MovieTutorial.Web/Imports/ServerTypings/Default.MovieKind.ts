namespace MovieTutorial.Default {
    export enum MovieKind {
        Film = 1,
        TvSeries = 2,
        MiniSeries = 3
    }
    Serenity.Decorators.registerEnumType(MovieKind, 'MovieTutorial.Default.MovieKind', 'MovieDB.MovieKind');
}

