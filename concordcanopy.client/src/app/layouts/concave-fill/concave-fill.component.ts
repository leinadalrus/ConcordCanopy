import { Component } from '@angular/core'
import { NgFor, NgIf } from "@angular/common"
import { CardComponent } from "../../components/card/card.component"

@Component({
  selector: 'app-concave-fill',
  templateUrl: './concave-fill.component.html',
  styleUrl: './concave-fill.component.css'
})
export class ConcaveFillComponent {
  cards: CardComponent[] = []
}
