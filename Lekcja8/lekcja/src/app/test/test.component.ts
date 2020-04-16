import { Component, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-test',
  templateUrl: './test.component.html',
  styleUrls: ['./test.component.css']
})
export class TestComponent implements OnInit {
  text: string;

  constructor(private http: HttpClient) { }

  ngOnInit(): void {
    this.http.post<any>('https://localhost:44325/api/data', "To jest tekst z Angulara").subscribe(x => {
      console.log(x);
      this.text = x.text;
    });
  }

}
