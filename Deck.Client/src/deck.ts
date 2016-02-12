import {Card} from './card';
import {inject} from "aurelia-framework";
import {HttpClient} from 'aurelia-fetch-client';
import 'fetch';

@inject(HttpClient)
export class Deck {
    cards: any[] = [];
    message: string;

    deckSize() {
        return this.cards.length;
    }

    constructor(private http: HttpClient) {
        http.configure(config => {
            config
                .withBaseUrl('http://localhost:56892/')
                .withDefaults({
                        mode: 'no-cors',
                        headers: {
                            'Accept': 'application/json'
                        }
                    }
                );
        });

    }

    activate() {
        this.http.fetch('deck/cards')
            .then(response => response.json())
            .catch(e => { console.log(e); });
    }

    shuffle() {

    }
}