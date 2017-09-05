import { Aurelia, PLATFORM } from 'aurelia-framework';
import { Router, RouterConfiguration } from 'aurelia-router';

export class App {
    router: Router;

    configureRouter(config: RouterConfiguration, router: Router) {
        config.title = 'Aurelia';
        config.map([{
            route: ['', 'createiisweb'],
            name: 'Create-IIS-Web',
            settings: { icon: 'plus' },
            moduleId: PLATFORM.moduleName('../createiisweb/createiisweb'),
            nav: true,
            title: 'Schritt 1: Erstelle IIS Web'
        }]);

        this.router = router;
    }
}
