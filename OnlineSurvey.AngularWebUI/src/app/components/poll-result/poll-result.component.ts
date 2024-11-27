import { Component, Input, OnInit } from '@angular/core';
import { Chart } from 'chart.js';

@Component({
  selector: 'app-poll-result',
  templateUrl: './poll-result.component.html',
  styleUrls: ['./poll-result.component.css']
})
export class PollResultComponent implements OnInit {

  @Input() pollResults: any;

  constructor() { }

  ngOnInit() {
    this.getResult();
  }

  getResult(){
    const ctx = document.getElementById('resultsChart') as HTMLCanvasElement;
    new Chart(ctx, {
      type: 'bar',
      data: {
        labels: this.pollResults.options.map((o: any) => o.text),
        datasets: [
          {
            label: 'Votes',
            data: this.pollResults.options.map((o: any) => o.voteCount),
            backgroundColor: 'rgba(75, 192, 192, 0.2)',
            borderColor: 'rgba(75, 192, 192, 1)',
            borderWidth: 1,
          },
        ],
      },
    });
  }
}
