### NGRX ANGULAR

NgRx is a state management library for Angular applications that is inspired by Redux. It helps manage and centralize the state of your Angular application, making it easier to handle complex data and interactions. Here's a simple explanation of NgRx in Angular:

1. **Store**: NgRx creates a central store that holds the entire state of your Angular application. This state represents the data your components need to access and update.

2. **Actions**: Actions are plain JavaScript objects that describe something that happened in your application. They are the only way to modify the state in the NgRx store. Actions have a `type` property that describes the action and can include additional data (payload).

3. **Reducers**: Reducers are pure functions that specify how the state changes in response to actions. They take the current state and an action and return a new state. Reducers are responsible for updating the application's state in an immutable way.

4. **Dispatch**: To make changes to the state, you dispatch an action. Dispatching an action is like saying, "Hey, something just happened!" NgRx then uses the reducer functions to determine how the state should change based on that action.

5. **Selectors**: Selectors are functions used to derive data from the store. They take the store's state and return a specific piece of data. This helps to keep the component code clean and independent of the store structure.

6. **Effects** (Optional): Effects are used for managing side effects like HTTP requests and async operations. They listen for actions, perform async tasks, and dispatch new actions with the results.

7. **Subscription**: Angular components can subscribe to the NgRx store. When the state changes due to dispatched actions, subscribed components are notified, and they can re-render to reflect the new state.

In summary, NgRx provides a clear and predictable way to manage and update your Angular application's state. It promotes a unidirectional data flow, which means data flows in one direction, from the store to the components. This can help you write more maintainable and predictable code, especially in larger and more complex Angular applications.


## EXAMPLE
1. **Packages**: 
```bash
npm install @ngrx/store @ngrx/effects @ngrx/entity @ngrx/store-devtools
```
2. **Create Actions**: Define the actions for your counter.
```typescript
// counter.actions.ts
import { createAction } from '@ngrx/store';

export const increment = createAction('[Counter Component] Increment');
export const decrement = createAction('[Counter Component] Decrement');
export const reset = createAction('[Counter Component] Reset');
```
3. **Create Reducer**: Define how the state changes in response to actions.
```typescript
// counter.reducer.ts
import { createReducer, on } from '@ngrx/store';
import * as CounterActions from './counter.actions';

export const initialState = 0;

const _counterReducer = createReducer(
  initialState,
  on(CounterActions.increment, state => state + 1),
  on(CounterActions.decrement, state => state - 1),
  on(CounterActions.reset, () => 0)
);

export function counterReducer(state, action) {
  return _counterReducer(state, action);
}
```
4. **Set up Store**: Provide the store at the root level of your Angular application.
```typescript
// app.module.ts
import { NgModule } from '@angular/core';
import { StoreModule } from '@ngrx/store';
import { counterReducer } from './counter.reducer';

@NgModule({
  imports: [
    StoreModule.forRoot({ count: counterReducer })
  ],
  declarations: [/* your components */],
  providers: [],
  bootstrap: [/* your root component */]
})
export class AppModule { }
```
5. **Use the Store in Component**: Connect your component to the store and dispatch actions.
```typescript
// counter.component.ts
import { Component } from '@angular/core';
import { Store } from '@ngrx/store';
import { Observable } from 'rxjs';
import { increment, decrement, reset } from './counter.actions';

@Component({
  selector: 'app-counter',
  template: `
    <button (click)="increment()">Increment</button>
    <div>Current Count: {{ count$ | async }}</div>
    <button (click)="decrement()">Decrement</button>
    <button (click)="reset()">Reset</button>
  `
})
export class CounterComponent {
  count$: Observable<number>;

  constructor(private store: Store<{ count: number }>) {
    this.count$ = store.select('count');
  }

  increment() {
    this.store.dispatch(increment());
  }

  decrement() {
    this.store.dispatch(decrement());
  }

  reset() {
    this.store.dispatch(reset());
  }
}
```

This is a basic setup to get you started with NgRx in an Angular application. It handles the state management for a simple counter. Remember, NgRx can become more complex as your application grows, but this should give you a good starting point.
