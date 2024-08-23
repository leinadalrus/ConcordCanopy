import { HttpClient } from "@angular/common/http"
import { Component, OnInit } from '@angular/core'

// Interface for REST-ful data
interface ArticleArtificer {
  id: string
  title: string
  description: string
  author: string
  date: string
}
// ... Break-line spacing for readability

@Component({
  selector: 'app-article',
  templateUrl: './article.component.html',
  styleUrl: './article.component.css'
})
export class ArticleComponent implements OnInit {
  public articles: ArticleArtificer[] = []

  constructor(private http: HttpClient) { }

  ngOnInit() {
    this.getArticles
  }

  getArticles() {
    this.http.get<ArticleArtificer[]>("/articles").subscribe(
      result => this.articles = result,
      error => console.error(error)
    )
  }
}
