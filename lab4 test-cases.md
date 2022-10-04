# lab4 test-cases

E2E-тесты должны проверить, что все элементы корректно связаны между собой.

[https://medium.com/@oxmap/сквозные-тесты-eb9e417875c](https://medium.com/@oxmap/%D1%81%D0%BA%D0%B2%D0%BE%D0%B7%D0%BD%D1%8B%D0%B5-%D1%82%D0%B5%D1%81%D1%82%D1%8B-eb9e417875c) - е2е тесты

[https://www.lambdatest.com/learning-hub/data-driven-testing#a](https://www.lambdatest.com/learning-hub/data-driven-testing#a) - data drive testing

**Тест-кейс №1**

| Номер | 1 |
| --- | --- |
| Заголовок| Отправка сообщения через форму обратной связи на странице товара |
| Предусловие
 | Открыта страница конкретного товара |
| Шаг
 | Ожидаемый результат
 |
| Снизу под кнопкой “В корзину” нажать на ссылку “Заказать обратную связь” | Открылась форма обратной связи |
| Ввести Артём в поле “Ваше имя” | В поле “Ваше имя” отображается Артём |
| Ввести номер +375295753614 в поле “Телефон” | В поле “Телефон” отображается номер +375295753614 |
| Ввести email arkrasovski1996@gmail.com в поле ”E-mail” | В поле “E-mail” отображается arkrasovski1996@gmail.com |
| Нажать под заполняемой формой на кнопку “Отправить” | Под надписью «Форма обратной связи» появился текст “Спасибо за обращение. Ваше сообщение отправлено. Наш менеджер свяжется с вами в ближайшее время.” |
| Проверить почту arkrasovski1996@gmail.com | На почту пришло сообщение, отправленное с сайта через форму обратной связи и содержащее в теле сообщения данные, введённые на шагах 2-4. |

**Тест-кейс №2**

| Номер | 2 |
| --- | --- |
| Заголовок
 | Совершение заказа через форму “Оформление заказа” на странице оформления заказа |
| Предусловие
 | Открыта корзина с выбранным в ней товаром |
| Шаг
 | Ожидаемый результат
 |
| Снизу под товаром нажать на кнопку “Оформить заказ” | Открылась страница оформления заказа |
| Ввести Артем в поле “Имя”  | В поле “Имя” отображается Артем |
| Ввести Красовский в поле “Фамилия” | В поле “Фамилия” отображается Красовский |
| Ввести номер +375295753614 в поле “Телефон” | В поле “Телефон” отображается номер +375295753614 |
| Ввести email arkrasovski1996@gmail.com в поле ”E-mail” | В поле “E-mail” отображается arkrasovski1996@gmail.com |
| Ввести “Голубка 10” в поле “Адрес” | В поле “Адрес” отображается “Голубка 10” |
| Нажать под заполняемой формой на кнопку “Оформить заказ” | Появилось окно с текстом “Спасибо за покупку” |
| Проверить почту arkrasovski1996@gmail.com | На почту пришло сообщение, отправленное с сайта через форму оформления заказа и содержащее в теле сообщения данные, введённые на шагах 2-6. |

**Тест-кейс №3**

| Номер | 3 |
| --- | --- |
| Заголовок
 | Добавление товара в корзину |
| Предусловие
 | Открыта главная страница сайта |
| Шаг
 | Ожидаемый результат
 |
| Снизу под часами “Однострелочник” нажать на кнопку “Купить” | Открылась страница товара (часы “Однострелочник”) |
| Снизу под ценой часов нажать на кнопку “В корзину” | Значок корзины изменился: отобразилась цифра 1 |
| Нажать на значок корзины | В корзине отображаются часы “однострелочник” и id этих часов |

Тест-кейс №4

| Номер | 4 |
| --- | --- |
| Заголовок
 | Получение скидки по промокоду |
| Предусловие
 | В корзине лежат часы “Однострелочник” |
| Шаг
 | Ожидаемый результат
 |
| Снизу под часами “Однострелочник” ввести промокод “Test” | В поле “Введите промокод для скидки:” отображается промокод “Test” |
| Нажать enter | Под кнопкой “Получить скидку” отображается промокод “Test” |
| Навести мышкой на промокод “Test” | Под промокодом отображается “Не найден” |

Тест-кейс №5

| Номер | 5 |
| --- | --- |
| Заголовок
 | Заказ часов с индивидуальным дизайном |
| Предусловие
 | Открыта главная страница сайта |
| Шаг
 | Ожидаемый результат
 |
| В меню навигации нажать “Спецзаказ” | Открылась страница “Часы с индивидуальным дизайном” |
| Прокрутить вниз до формы “Обратный звонок” | Открыта форма “Обратный звонок” |
| Ввести в поле “Ф.И.О.” имя Красовский Артем Николаевич | В поле “Ф.И.О.” отображается Красовский Артем Николаевич |
| Ввести в поле ”Телефон” номер +375295753614 | В поле “Телефон” отображается номер +375295753614 |
| Ввести в поле ”E-mail” почту arkrasovski1996@gmail.com | В поле “E-mail” введена почта arkrasovski1996@gmail.com |
| Ввести в поле “Сообщение” текст “Test” | В поле “Сообщение” введен текст “Test” |
| Нажать на кнопку “Отправить” | появилось окно с надписью “Спасибо! Данные успешно отправлены” |
| Проверить почту arkrasovski1996@gmail.com | На почту пришло сообщение, отправленное с сайта через форму “Обратный звонок” и содержащее в теле сообщения данные, введённые на шагах 3-6. |

**Тест-кейс №6**

| Номер | 6 |
| --- | --- |
| Заголовок
 | Удаление товара из корзины |
| Предусловие
 | Открыта корзина, добавлен товар часы “Однострелочник” |
| Шаг
 | Ожидаемый результат
 |
| Снизу под количеством товаров нажать кнопку “Удалить” | Товар удален, появилась надпись “Ваша корзина пуста” |

**Тест-кейс №7**

| Номер | 7 |
| --- | --- |
| Заголовок
 | Сброс настроек подбора товара |
| Предусловие
 | Открыта страница “Наручные часы” |
| Шаг
 | Ожидаемый результат
 |
| В поле цены “до” ввести 200 | В поле цены “до” введено 200 |
| В секции “Механизм” выбрать чекбокс “Механческий” | Выбран чекбокс “Механический” |
| Пролистать вниз до кнопки “Сбросить” | Видна кнопка “Сбросить” |
| Нажать кнопку “Сбросить” | Страница перезагружена, все поля и чекбоксы очищены |

**Тест-кейс №8**

| Номер | 8 |
| --- | --- |
| Заголовок
 | Скачивание документов |
| Предусловие
 | Открыта страница “Документы” |
| Шаг
 | Ожидаемый результат
 |
| Нажать на кнопку скачивания документа справа от документа | Документ открывается в формате pdf в браузере |
| Нажать кнопку скачать в правом верхнем углу | Документ скачан на ваш компьютер |

**Тест-кейс №9**

| Номер | 9 |
| --- | --- |
| Заголовок
 | Изменение числа товаров в корзине |
| Предусловие
 | Открыта корзина, выбраны часы “Однострелочник” |
| Шаг
 | Ожидаемый результат
 |
| Нажать кнопку “+” | Число товаров стало 2 |
| Нажать кнопку “-” | Число товаров стало 1 |

Тест-кейс №10

| Номер | 10 |
| --- | --- |
| Заголовок
 | Заказ автомобильных кварцевых часов |
| Предусловие
 | Открыта главная страница сайта |
| Шаг
 | Ожидаемый результат
 |
| Нажать на ссылку “О нас” | Появилось выпадающее меню ссылки “О нас” |
| Нажать в выпадающем меню на ссылку “Автомобильные кварцевые часы” | Перекинуло на сайт с автомобильными кварцевыми часами |
| Нажать на кнопку “Заказать” под информацией об автомобильных кварцевых часах | Открылась форма заказа звонка |
| Ввести Артём в поле “Ваше имя” | В поле “Ваше имя” отображается Артём |
| Ввести номер +375295753614 в поле “Телефон” | В поле “Телефон” отображается номер +375295753614 |
| Ввести в поле “Сообщение” текст “Test” | В поле “Сообщение” введен текст “Test” |
| Нажать кнопку “Отправить заявку” | Появилось окно с надписью “Спасибо! Данные успешно отправлены.” |
| Проверить телефон | На номер +375295753614 позвонил оператор магазина |