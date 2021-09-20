namespace MovieTutorial.Default {
    export interface MovieCastRow {
        MovieCastId?: number;
        MovieId?: number;
        PersonId?: number;
        Character?: string;
        MovieTitle?: string;
        MovieDescription?: string;
        MovieStoryline?: string;
        MovieYear?: number;
        MovieReleaseDate?: string;
        MovieRuntime?: number;
        MovieKind?: number;
        PersonFullname?: string;
        PersonFirstName?: string;
        PersonLastname?: string;
        PersonBirthDate?: string;
        PersonBirthPlace?: string;
        PersonGender?: number;
        PersonHeight?: number;
    }

    export namespace MovieCastRow {
        export const idProperty = 'MovieCastId';
        export const nameProperty = 'Character';
        export const localTextPrefix = 'Default.MovieCast';
        export const deletePermission = 'Administration:General';
        export const insertPermission = 'Administration:General';
        export const readPermission = 'Administration:General';
        export const updatePermission = 'Administration:General';

        export declare const enum Fields {
            MovieCastId = "MovieCastId",
            MovieId = "MovieId",
            PersonId = "PersonId",
            Character = "Character",
            MovieTitle = "MovieTitle",
            MovieDescription = "MovieDescription",
            MovieStoryline = "MovieStoryline",
            MovieYear = "MovieYear",
            MovieReleaseDate = "MovieReleaseDate",
            MovieRuntime = "MovieRuntime",
            MovieKind = "MovieKind",
            PersonFullname = "PersonFullname",
            PersonFirstName = "PersonFirstName",
            PersonLastname = "PersonLastname",
            PersonBirthDate = "PersonBirthDate",
            PersonBirthPlace = "PersonBirthPlace",
            PersonGender = "PersonGender",
            PersonHeight = "PersonHeight"
        }
    }
}

