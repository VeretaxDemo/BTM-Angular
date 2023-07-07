import { NgModule } from '@angular/core';
import { ServerModule } from '@angular/platform-server';
//import { ModuleMapLoaderModule } from '@nguniversal/module-map-ngfactory-loader';
import { AppComponent } from './app.component';
import { AppModule } from './app.module';
import { ContractModule } from './contract/contract.module';

@NgModule({
  imports: [
    AppModule,
    ServerModule,
    ContractModule,
    //ModuleMapLoaderModule
  ],
    bootstrap: [AppComponent]
})
export class AppServerModule { }
