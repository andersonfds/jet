import { Injectable } from '@angular/core';
import { ClassConstructor, plainToClass } from 'class-transformer';

@Injectable({
  providedIn: 'root'
})
export class LocalStorageService {
  private storage: Storage;

  constructor() {
    this.storage = window.localStorage;
  }

  set<T>(key: string, value: T) {
    this.storage.setItem(key, JSON.stringify(value));
  }

  remove(key: string) {
    this.storage.removeItem(key);
  }

  clear() {
    this.storage.clear();
  }

  getAs<T>(key: string, ctr: ClassConstructor<T>): T | T[] | null {
    let item = this.getRaw(key);

    if (!item)
      return null;

    return plainToClass(ctr, JSON.parse(item));
  }

  getRaw(key: string): string | null {
    return this.storage.getItem(key);
  }
}
