import { Component } from '@angular/core';
import { CardComponent } from "../../components/card/card.component"

@Component({
  selector: 'app-neusladder',
  templateUrl: './neusladder.component.html',
  styleUrl: './neusladder.component.css'
})
export class NeusladderComponent {
  cards: CardComponent[] = []
}
