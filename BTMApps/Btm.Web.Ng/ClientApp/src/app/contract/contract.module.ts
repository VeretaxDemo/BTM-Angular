import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { ContractComponent } from './contract.component';
import { ContractCategoryComponent } from '../contract-category/contract-category.component';
import { ContractTypeComponent } from '../contract-type/contract-type.component';

@NgModule({
  declarations: [
    ContractComponent,
    ContractCategoryComponent,
    ContractTypeComponent,

  ],
  imports: [
    CommonModule
  ]
})
export class ContractModule { }
