
import {Suit} from 'suit';

export class Card {
    suit: Suit.Suit;
    rank: string;

    //constructor(pip: string, rank: string) {
    //    var color = "Red";
    //    if (pip === "Spade" || pip === "Club") {
    //        color = "Black";
    //    }
    //    this.suit = new Suit(pip, color);
    //    this.rank = rank;
    //}

    constructor(suit: Suit, rank: string) {
        this.suit = suit;
        this.rank = rank;
    }
}


//export class App {
//    display: string = 'Whatevs!';

//}