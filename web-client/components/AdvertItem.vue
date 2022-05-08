<template>
  <article class=" gap p-4 bg-white w-96 font-sans rounded-md" style="box-shadow: rgba(0, 0, 0, 0.16) 0px 1px 4px;">
    <div class="cover">
      <img class="w-full" :src="advert.image" alt="">
    </div>
    <div class="flex flex-col gap-2">
      <div class="flex flex-col gap-1">
        <div class="flex justify-between">
          <h2 class="title text-xl font-sans tracking-wide font-medium">{{advert.title}}</h2>
          <button><span class="ri-more-fill text-2xl"></span></button>
        </div>
        <p>{{advert.company}}</p>
      </div>
      <p class="description">{{advert.description}}</p>
    </div>
  </article>
</template>

<script>
export default {
  name: "AdvertItem",
  props: {
    advert: Object
  }
}
</script>

<style scoped>
  article {
    transition: 200ms ease-in-out;
  }
  article:hover {
    transform: scale(103%);

  }

  .title {
    max-width: 21ch;
    text-overflow: ellipsis;
    overflow: hidden;
    white-space: nowrap;
  }

  .description {
    display: -webkit-box;
    -webkit-line-clamp: 2;
    -webkit-box-orient: vertical;
    overflow: hidden;
    text-overflow: ellipsis;
  }

  .cover {
    display: grid;
    place-items: center;
    aspect-ratio: 1 / 1;
  }

  img {
    margin-inline: auto;
    object-fit: cover;

    max-height: 65%;
    max-width: 65%;
    padding: 1rem;
  }

</style>
