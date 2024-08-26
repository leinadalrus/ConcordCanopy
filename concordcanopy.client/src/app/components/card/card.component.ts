import { HttpClient } from "@angular/common/http"
import { Component, OnInit } from '@angular/core'
// ...

interface CardArtificer {
  id: string
  title: string
  description: string
  media: string
}
// ...

@Component({
  selector: 'app-card',
  templateUrl: './card.component.html',
  styleUrl: './card.component.css'
})
export class CardComponent implements OnInit {
  public artifacts: CardArtificer[] = []

  constructor(private http: HttpClient) { }

  ngOnInit(): void {
    this.getCards
  }

  getCards() {
    this.http.get<CardArtificer[]>("/cards").subscribe(
      result => this.artifacts = result,
      error => console.error(error)
    )
  }
}
