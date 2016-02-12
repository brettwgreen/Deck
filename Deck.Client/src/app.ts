import {RouterConfiguration, Router} from 'aurelia-router';

export class App {
    router: Router;

    configureRouter(config: RouterConfiguration, router: Router) {
        config.title = 'Aurelia';
        config.map([
            { route: ['', 'welcome'], name: 'welcome', moduleId: './welcome', nav: true, title: 'Welcome' },
            { route: ['deck', 'deck'], name: 'deck', moduleId: './deck', nav: true, title: 'Deck' }
        ]);

        this.router = router;
    }
}