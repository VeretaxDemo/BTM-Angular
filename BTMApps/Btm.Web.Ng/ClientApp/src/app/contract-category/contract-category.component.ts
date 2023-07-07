import { Component, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-contract-category',
  templateUrl: './contract-category.component.html',
  styleUrls: ['./contract-category.component.css']
})
export class ContractCategoryComponent implements OnInit {
  contractCategories: any[]=[];

  constructor(private http: HttpClient) { }

  ngOnInit() {
    this.fetchContractCategories();
  }

  fetchContractCategories() {
    this.http.get<any[]>('/api/contractcategory')
      .subscribe(
        (data: any[]) => {
          this.contractCategories = data;
        },
        error => {
          console.error('Error fetching contract categories:', error);
        }
      );
  }

}
