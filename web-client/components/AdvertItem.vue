<template>
  <article class="bg-white z-0 p-4 w-96 rounded-md drop-shadow transition ease-in-out hover:scale-105">
    <div class="grid place-items-center aspect-video">
      <img :src="advert.image" alt="" class="h-full mx-auto object-contain p-4">
    </div>
    <div class="flex justify-between items-center">
      <h2 class="max-w-ch-6 font-medium text-ellipsis whitespace-nowrap overflow-hidden">
        {{ advert.title }}
      </h2>
      <button @click="$emit('openModal')" aria-label="details">
        <span class="ri-more-fill text-2xl"></span>
      </button>
    </div>
    <h3>
      {{ advert.company }}
    </h3>
    <p class="line-clamp-2 text-ellipsis overflow-hidden mt-2">
      {{ advert.description }}
    </p>
  </article>
</template>

<script>
export default {
  props: {
    advert: Object
  }
}
</script>
