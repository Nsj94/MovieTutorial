
namespace MovieTutorial.Default {

    @Serenity.Decorators.registerClass()
    export class MovieCastGrid extends Serenity.EntityGrid<MovieCastRow, any> {
        protected getColumnsKey() { return 'Default.MovieCast'; }
        protected getDialogType() { return MovieCastDialog; }
        protected getIdProperty() { return MovieCastRow.idProperty; }
        protected getInsertPermission() { return MovieCastRow.insertPermission; }
        protected getLocalTextPrefix() { return MovieCastRow.localTextPrefix; }
        protected getService() { return MovieCastService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}