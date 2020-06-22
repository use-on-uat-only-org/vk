---
layout: default
title: Метод Account.GetAppPermissions
permalink: account/getAppPermissions/
comments: true
---
# Метод Account.GetAppPermissions
Получает настройки текущего пользователя в данном приложении.

Страница документации ВКонтакте [account.getAppPermissions](https://vk.com/dev/account.getAppPermissions).

Этот метод можно вызвать с [ключом доступа пользователя](https://vk.com/dev/access_token).

## Синтаксис
``` csharp
public long GetAppPermissions(long? userId = null)
```

## Параметры
+ **userId** - Идентификатор пользователя, информацию о настройках которого необходимо получить. По умолчанию — текущий пользователь. 
Положительное число, по умолчанию идентификатор текущего пользователя, **обязательный параметр**.

## Результат
После успешного выполнения возвращает битовую маску настроек текущего пользователя в данном приложении. 

[Список возможных настроек прав доступа](https://vk.com/dev/permissions)

## Пример

Если Вы хотите получить права на Доступ к друзьям и Доступ к статусам пользователя, то Ваша битовая маска будет равна: 2 + 1024 = 1026. 
Если, имея битовую маску 1026, Вы хотите проверить, имеет ли она доступ к друзьям — Вы можете сделать 1026 &amp; 2. Например alert(1026 &amp; 2); 

``` csharp
var myPermission = _api.Account.GetAppPermissions();
```

## Версия Вконтакте API v.5.110
Дата обновления: 19.06.2020 3:49