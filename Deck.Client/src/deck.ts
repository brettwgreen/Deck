import {Card} from './card';

export class Deck {
    cards: Card[];
    display: string = 'deck!';

    deckSize() {
        return this.cards.length;
    }

    constructor() {
        this.cards = new Array(2);
        this.cards[0] = new Card("Diamond", "Queen");
        this.cards[1] = new Card("Diamond", "King");
        console.log('Constructor fired');
    }

    shuffle() {

    }
}